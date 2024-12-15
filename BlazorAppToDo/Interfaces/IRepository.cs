using BlazorAppToDo.Model;

namespace BlazorAppToDo.Interfaces
{
    public interface IRepository<T>
    {
        public Task<List<T>> GetAllAsync();
    }
}
