using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListingTodos.Repositories
{
    public class TodoRepository
    {
        public TodoContext todoContext;

        public TodoRepository(TodoContext todoContext)
        {
            this.todoContext = todoContext;
        }

        public List<Todo> todoList = new List<Todo>()
        {
            new Todo() { Title = "Start the day" },
            new Todo() { Title = "Finish H2 workshop1" },
            new Todo() { Title = "Finish JPA workshop2" },
            new Todo() { Title = "Create a CRUD project" }
        };

        public List<Todo> ReturnList()
        {
            return todoContext.Todos.ToList();
        }

        public List<Todo> ReturnActiveList()
        {
            return todoContext.Todos.Where(t => t.IsDone == false).ToList();
        }

        public List<Todo> BoolList(bool isActive)
        {
            if (isActive)
            {
                return ReturnActiveList();
            }
            return ReturnList();
        }

        public void CreateNewItem(Todo todo)
        {
            todoContext.Todos.Add(todo);
            todoContext.SaveChanges();
        }

        public void DeleteItem(long index)
        {
            Todo t = todoContext.Todos.FirstOrDefault(x => x.Id == index);
            todoContext.Todos.Remove(t);
            todoContext.SaveChanges();
        }

        
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
