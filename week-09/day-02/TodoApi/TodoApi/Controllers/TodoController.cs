using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Entities;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly TodoContext todoContext;

        public TodoController(TodoContext todoContext)
        {
            this.todoContext = todoContext;

            if (todoContext.TodoItems.Count() == 0)
            {
                todoContext.TodoItems.Add(new TodoItem { Name = "Item1" });
                todoContext.SaveChanges();
            }
        }
    }
}
