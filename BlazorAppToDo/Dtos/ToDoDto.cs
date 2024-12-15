using BlazorAppToDo.Model;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppToDo.Dto
{
    public class ToDoDto
    {
        public int Id { get; set; } 
         
        public string Task { get; set; } = string.Empty;
         
        public string? Description { get; set; }

        public bool IsCompleted { get; set; } = false;
         
        public DateTime CreatedAt { get; set; } = DateTime.Now;
         
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public ToDoDto(ToDo toDo)
        {
            Id = toDo.Id;
            Task = toDo.Task;
            Description = toDo.Description;
            CreatedAt = toDo.CreatedAt;
            UpdatedAt = toDo.UpdatedAt;
            IsCompleted = toDo.IsCompleted;
        }
    }
}
