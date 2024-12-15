using BlazorAppToDo.Dto;
using BlazorAppToDo.Interfaces; 
using Microsoft.AspNetCore.Components;

namespace BlazorAppToDo.Components.Pages.Home
{
    public class HomeBase : ComponentBase
    {
        [Inject]
        public required IToDoRepository ToDoRepository { get; set; }

        public List<ToDoDto> ToDoList = new();

        protected override async Task OnInitializedAsync()
        {
            // Загружаем задачи из репозитория и преобразуем в DTO
            var todoList = await ToDoRepository.GetAllAsync();

            foreach(var todo in todoList)
            {
                ToDoList.Add(new ToDoDto(todo));
            } 
        }

    }
}
