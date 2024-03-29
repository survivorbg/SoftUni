﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using PokemonReviewApp.Repository;
using System.Collections.Generic;

namespace PokemonReviewApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class OwnerController : Controller
{
    private readonly IOwnerRepository ownerRepository;
    private readonly IMapper mapper;

    public OwnerController(IOwnerRepository ownerRepository, IMapper mapper)
    {
        this.ownerRepository = ownerRepository;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ICollection<OwnerDto>))]
    public IActionResult GetOwners()
    {
        var owners = mapper.Map<ICollection<OwnerDto>>(ownerRepository.GetOwners());

        return Ok(owners);
    }

    [HttpGet("{ownerId}")]
    [ProducesResponseType(200, Type = typeof(OwnerDto))]
    [ProducesResponseType(400)]
    public IActionResult GetOwner(int ownerId)
    {
        var owner = mapper.Map<OwnerDto>(ownerRepository.GetOwner(ownerId));

        if (owner == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(owner);
    }

    [HttpGet("{pokeId}/owners")]
    [ProducesResponseType(200, Type = typeof(ICollection<OwnerDto>))]
    [ProducesResponseType(400)]
    public IActionResult GetOwnerOfAPokemon(int pokeId)
    {
        var owners = mapper.Map<ICollection<OwnerDto>>(ownerRepository.GetOwnerOfAPokemon(pokeId));

        if (owners == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(owners);
    }

    [HttpGet("{ownerId}/pokemons")]
    [ProducesResponseType(200, Type = typeof(ICollection<PokemonDto>))]
    [ProducesResponseType(400)]
    public IActionResult GetPokemonsByOwnerId(int ownerId)
    {
        var pokemons = mapper.Map<ICollection<PokemonDto>>(ownerRepository.GetPokemonByOwner(ownerId));

        if (pokemons == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(pokemons);
    }

    [HttpPost]
    [ProducesResponseType(204)]
    [ProducesResponseType(400)]
    public IActionResult CreateOwner([FromBody] OwnerAddDto ownerCreate)
    {
        if (ownerCreate == null)
        {
            return BadRequest();
        }

        var owner = ownerRepository.GetOwners()
            .Where(o => o.FirstName.Trim().ToLower() == ownerCreate.FirstName.Trim().ToLower() && o.LastName.Trim().ToLower() == ownerCreate.LastName.Trim().ToLower())
            .FirstOrDefault();

        if (owner != null)
        {
            ModelState.AddModelError("", "Owner already exists!");
            return StatusCode(402, ModelState);
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var ownerMap = mapper.Map<Owner>(ownerCreate);

        if (!ownerRepository.CreateOwner(ownerMap))
        {
            ModelState.AddModelError("", "Something went wrong while saving!");
            return StatusCode(500, ModelState);
        }

        return Ok("Successfully created!");
    }

}
