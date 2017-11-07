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
                todoContext.TodoItems.Add(new TodoItem { Name = "Item2" });
                todoContext.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<TodoItem> GetAll()
        {
            return todoContext.TodoItems.ToList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(long id)
        {
            var item = todoContext.TodoItems.FirstOrDefault(t => t.Id == id);
            if (item == null)
            {
                return NotFound();
            }
            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] TodoItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            todoContext.TodoItems.Add(item);
            todoContext.SaveChanges();

            return CreatedAtRoute("GetTodo", new { id = item.Id }, item);
        }
    }
}
