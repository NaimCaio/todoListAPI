using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactaAPI.Models.Interfaces
{
    public interface ITodoListService
    {
        List<Todo> GetTodoList();
        Todo AddTodo(string desc);
        Todo DeleteTodo(string desc);
        Todo UpdateTodo(int id, string desc);
    }
}
