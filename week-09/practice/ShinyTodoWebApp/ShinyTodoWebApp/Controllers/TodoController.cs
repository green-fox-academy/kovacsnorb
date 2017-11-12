﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShinyTodoWebApp.Repositories;
using ShinyTodoWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ShinyTodoWebApp.Controllers
{
    public class TodoController : Controller
    {
        TodoRepository TodoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            TodoRepository = todoRepository;
        }

        [Route("")]
        [Route("todo")]
        public IActionResult List([FromQuery] string isActive)
        {
            var myTodoList = TodoRepository.ListAllTodo(isActive);
            return View(myTodoList);
        }

        [Route("todo/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("todo/add")]
        [HttpPost]
        public IActionResult Add(Todo todo)
        {
            TodoRepository.AddNew(todo);
            return RedirectToAction("List");
        }
    }
}
