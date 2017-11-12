using ShinyTodoWebApp.Entities;
using ShinyTodoWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShinyTodoWebApp.Repositories
{
    public class TodoRepository
    {
        TodoContext TodoContext;

        public TodoRepository(TodoContext todoContext)
        {
            TodoContext = todoContext;
        }

        public List<Todo> FillList()
        {
            List<Todo> myList = new List<Todo>
            {
                new Todo()
                {
                    Id = 1,
                    Title = "Go home",
                    IsUrgent = true,
                    IsDone = false,
                    IsVisible = true,
                },

                new Todo()
                {
                    Id = 2,
                    Title = "Drink coffee",
                    IsUrgent = false,
                    IsDone = true,
                    IsVisible = true,
                }
            };

            return myList;
        }

        public List<Todo> ListAllTodo()
        {
            List<Todo> myList = new List<Todo>();
            foreach (var todo in TodoContext.Todos)
            {
                myList.Add(todo);
            }

            return myList;
        }
    }
}
