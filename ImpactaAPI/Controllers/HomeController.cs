using ImpactaAPI.Models;
using ImpactaAPI.Models.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("TodoListPolicy")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITodoListService _service;


        public HomeController(ILogger<HomeController> logger, ITodoListService service)
        {
            _logger = logger;
            _service = service;
        }
        [HttpGet]
        [Route("Todolist")]
        public List<Todo> TodoList()
        {
            var todoList = _service.GetTodoList();
            return todoList;
        }
        [HttpPost]
        [Route("addTodo")]
        public Todo AddTodoOnList([FromBody] string desc)
        {
            var todo = _service.AddTodo(desc);
            return todo;
        }

        [HttpPost]
        [Route("deleteTodo")]
        public Todo DeleteTodoOfList([FromBody] string desc)
        {
            var todo = _service.DeleteTodo(desc);
            return todo;
        }
        [HttpPost]
        [Route("editTodo")]
        public Todo EditTodoOnList([FromBody] int id,string desc)
        {
            var todo = _service.UpdateTodo(id,desc);
            return todo;
        }



    }
}
