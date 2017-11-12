﻿using ShinyTodoWebApp.Entities;
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

        public List<Todo> ListAllTodo(string inputStatus)
        {
            if (inputStatus is null)
            {
                return TodoContext.Todos.ToList();
            }
            else
            {
                return TodoContext.Todos.Where(t => t.IsDone != Boolean.Parse(inputStatus)).ToList();
            }
        }
    }
}
