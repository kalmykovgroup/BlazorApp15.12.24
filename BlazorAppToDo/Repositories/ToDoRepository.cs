using BlazorAppToDo.Data;
using BlazorAppToDo.Interfaces;
using BlazorAppToDo.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppToDo.Repositories
{
    public class ToDoRepository : IToDoRepository
    {

        private readonly AppDbContext _context;

        public ToDoRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<ToDo>> GetAllAsync()
        {
            return await _context.ToDoList.ToListAsync();
        }
    }
}
