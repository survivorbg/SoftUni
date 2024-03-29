﻿using HouseRentingSystem.Attributes;
using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.House;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HouseRentingSystem.Controllers;

public class HouseController : BaseController
{
    private readonly IHouseService houseService;
    private readonly IAgentService agentService;

    public HouseController(IHouseService houseService, IAgentService agentService)
    {
        this.houseService = houseService;
        this.agentService = agentService;
    }

    [AllowAnonymous]
    [HttpGet]
    public async Task<IActionResult> All([FromQuery] AllHousesQueryModel query)
    {
        var model = await houseService.AllAsync(
            query.Category,
            query.SearchTerm,
            query.Sorting,
            query.CurrentPage,
            query.HousesPerPage
            );

        query.TotalHousesCount = model.TotalHousesCount;
        query.Houses = model.Houses;
        query.Categories = await houseService.AllCategoriesNamesAsync();

        return View(query);
    }

    [HttpGet]
    public async Task<IActionResult> Mine()
    {
        if (User.IsInRole("Admin"))
        {
            return RedirectToAction(actionName: "Mine", controllerName: "House", new { area = "Admin" });
        }

        var userId = User.Id();
        IEnumerable<HouseServiceModel> model;

        if (await agentService.ExistsByIdAsync(userId))
        {
            int agentId = await agentService.GetAgentIdAsync(userId) ?? 0;
            model = await houseService.AllHousesByAgentIdAsync(agentId);
        }
        else
        {
            model = await houseService.AllHousesByUserIdAsync(userId);
        }

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> Details(int id)
    {
        if (await houseService.ExistsAsync(id) == false)
        {
            return BadRequest();
        }

        var model = await houseService.HouseDetailsByIdAsync(id);

        return View(model);
    }

    [HttpGet]
    [MustBeAgent]
    public async Task<IActionResult> Add()
    {
        if (await agentService.ExistsByIdAsync(User.Id()) == false)
        {
            return RedirectToAction(nameof(AgentController.Become), "Agent");
        }

        var model = new HouseFormModel()
        {
            Categories = await houseService.AllCategoriesAsync()
        };

        return View(model);
    }

    [HttpPost]
    [MustBeAgent]
    public async Task<IActionResult> Add(HouseFormModel model)
    {
        if (await houseService.CategoryExistsAsync(model.CategoryId) == false)
        {
            ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist!");
        }

        if (!ModelState.IsValid)
        {
            model.Categories = await houseService.AllCategoriesAsync();
            return View(model);
        }

        int? agentId = await agentService.GetAgentIdAsync(User.Id());

        int newHouseId = await houseService.CreateAsync(model, agentId ?? 0);

        return RedirectToAction(nameof(Details), new { id = newHouseId });
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        if (await houseService.ExistsAsync(id) == false)
        {
            return BadRequest();
        }

        if (await houseService.HasAgentWithIdAsync(id, User.Id()) == false && User.IsAdmin() == false)
        {
            return Unauthorized();
        }

        var model = await houseService.GetHouseForModelByIdAsync(id);

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(int id, HouseFormModel model)
    {
        if (await houseService.ExistsAsync(id) == false)
        {
            return BadRequest();
        }

        if (await houseService.HasAgentWithIdAsync(id, User.Id()) == false && User.IsAdmin() == false)
        {
            return Unauthorized();
        }

        if (await houseService.CategoryExistsAsync(model.CategoryId) == false)
        {
            ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist!");
        }

        if (!ModelState.IsValid)
        {
            model.Categories = await houseService.AllCategoriesAsync();
            return View(model);
        }

        await houseService.EditAsync(id, model);

        return RedirectToAction(nameof(Details), new { id });
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        if (await houseService.ExistsAsync(id) == false)
        {
            return BadRequest();
        }

        if(await houseService.HasAgentWithIdAsync(id, User.Id()) == false && User.IsAdmin() == false)
        {
            return Unauthorized();
        }

        var house = await houseService.HouseDetailsByIdAsync(id);
        var model = new HouseDetailsViewModel()
        {
            Title = house.Title,
            Address = house.Address,
            ImageUrl = house.ImageUrl
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Delete(HouseDetailsViewModel model)
    {
        if (await houseService.ExistsAsync(model.Id) == false)
        {
            return BadRequest();
        }

        if (await houseService.HasAgentWithIdAsync(model.Id, User.Id()) == false && User.IsAdmin() == false)
        {
            return Unauthorized();
        }

        await houseService.DeleteAsync(model.Id);

        return RedirectToAction(nameof(All));
    }

    [HttpPost]
    public async Task<IActionResult> Rent(int id)
    {
        if (await houseService.ExistsAsync(id) == false)
        {
            return BadRequest();
        }

        if(await houseService.IsRentedAsync(id))
        {
            return BadRequest();
        }

        if(await agentService.ExistsByIdAsync(User.Id()) && User.IsAdmin() == false)
        {
            return Unauthorized();
        }

        await houseService.RentAsync(id, User.Id());

        return RedirectToAction(nameof(Mine));
    }

    [HttpPost]
    public async Task<IActionResult> Leave(int id)
    {
        if (await houseService.ExistsAsync(id) == false)
        {
            return BadRequest();
        }

        if (await houseService.IsRentedAsync(id) == false)
        {
            return BadRequest();
        }
        
        if (await agentService.ExistsByIdAsync(User.Id()) && !User.IsAdmin())
        {
            return Unauthorized();
        }

        if(await houseService.IsRentedByUserWithIdAsync(id,User.Id()) == false)
        {
            return Unauthorized();
        }

        await houseService.LeaveAsync(id);

        return RedirectToAction(nameof(Mine));
    }
}
