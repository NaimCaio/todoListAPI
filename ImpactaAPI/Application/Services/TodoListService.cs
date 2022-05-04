using ImpactaAPI.Models;
using ImpactaAPI.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactaAPI.Application.Services
{
    public class TodoListService : ITodoListService
    {
        private readonly IRepository<Todo> _todoRepository;
        public TodoListService(IRepository<Todo> userRepository)
        {
            _todoRepository = userRepository;
        }

        public List<Todo> GetTodoList()
        {
            var todoList= _todoRepository.List().ToList();
            return todoList;
        }

        public Todo AddTodo(string desc)
        {
            var newTodo = new Todo() { descricao = desc };
            try
            {
                _todoRepository.Add(newTodo);
                var todo = _todoRepository.FirstOrDeafault(t => t.descricao == desc);
                return todo;
            }
            catch (Exception)
            {

                throw new Exception("Falha ao inserir");
            }
            
            
        }
        public Todo DeleteTodo(string desc)
        {
            var newTodo = new Todo() { descricao = desc };
            try
            {
                _todoRepository.Remove(newTodo);
                return newTodo;
            }
            catch (Exception)
            {

                throw new Exception("Falha ao remover");
            }


        }
        public Todo UpdateTodo(int id,string desc)
        {
            var newTodo = new Todo() { Id= id, descricao = desc };
            try
            {
                _todoRepository.Edit(newTodo);
                return newTodo;
            }
            catch (Exception)
            {

                throw new Exception("Falha ao Editar");
            }


        }
    }
}
