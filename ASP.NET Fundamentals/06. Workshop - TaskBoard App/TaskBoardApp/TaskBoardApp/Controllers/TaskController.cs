﻿using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TaskBoardApp.Contracts;
using TaskBoardApp.Models.Task;
using TaskBoardApp.Services;

namespace TaskBoardApp.Controllers;

public class TaskController : Controller
{
    private readonly ITaskService taskService;

    public TaskController(ITaskService _taskService)
    {
        taskService = _taskService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> Create()
    {
        var boards = await taskService.GetBoardsAsync();
        var model = new TaskFormModel()
        {
            Boards = boards
        };
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Create(TaskFormModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }
        string currentUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);

        await taskService.CreateAsync(model, currentUserId);

        return RedirectToAction("All","Board");
    }

    public async Task<IActionResult> Details(int id)
    {
        var model = await taskService.DetailsAsync(id);
        if(model == null)
        {
            return BadRequest();
        }

        return View(model);
    }

}





