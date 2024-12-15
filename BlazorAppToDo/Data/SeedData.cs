using BlazorAppToDo.Model;

namespace BlazorAppToDo.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (context.ToDoList.Any()) return;

            context.ToDoList.AddRange(
                new ToDo { Task = "Сделать домашнее задание", IsCompleted = false },
                new ToDo { Task = "Купить продукты", IsCompleted = true },
                new ToDo { Task = "Прочитать книгу", IsCompleted = false }
            );

            context.SaveChanges();
        }
    }
}
