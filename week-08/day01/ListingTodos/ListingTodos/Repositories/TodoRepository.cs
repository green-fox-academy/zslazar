using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public class TodoRepository
    {
        //public TodoContext todoContext;

        //public TodoRepository(TodoContext todoContext)
        //{
        //    this.todoContext = todoContext;
        //}

        public List<Todo> todoList = new List<Todo>()
        {
            new Todo() { Title = "Start the day" },
            new Todo() { Title = "Finish H2 workshop1" },
            new Todo() { Title = "Finish JPA workshop2" },
            new Todo() { Title = "Create a CRUD project" }
        };

        //public TodoRepository()
        //{
        //    InitTodos();
        //}

        //private void InitTodos()
        //{
        //    todoList.Add(new Todo()
        //    {
        //        Title = "Start the day"
        //    });

        //    todoList.Add(new Todo()
        //    {
        //        Title = "Finish H2 workshop1"
        //    });

        //    todoList.Add(new Todo()
        //    {
        //        Title = "Finish JPA workshop2"
        //    });

        //    todoList.Add(new Todo()
        //    {
        //        Title = "Create a CRUD project"
        //    });
        //}

    }
}
