using PostgreTest.Entities;
using PostgreTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostgreTest.Repositories
{
    public class TodoRepository
    {
        TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public List<Todo> GetTodos()
        {
            var myList = todoContext.Todos.ToList();
            return myList;
        }

        public void AddNew()
        {
            var newTodo = new Todo
            {
                IsDone = false,
                IsUrgent = true,
                Title = "Make the milk"
            };
            todoContext.Todos.Add(newTodo);
            todoContext.SaveChanges();
        }
    }
}
