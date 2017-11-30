using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PostgreTest.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PostgreTest.Controllers
{
    public class TodoController : Controller
    {
        TodoRepository todoRepository;

        public TodoController(TodoRepository todoRepository)
        {
            this.todoRepository = todoRepository;
        }

        [Route("")]
        [Route("todo")]
        public IActionResult Index()
        {
            var myTodoList = todoRepository.GetTodos();
            return Json(myTodoList);
        }

        [Route("todo/add")]
        public IActionResult Add()
        {
            todoRepository.AddNew();
            return RedirectToAction("Index");
        }
    }
}
