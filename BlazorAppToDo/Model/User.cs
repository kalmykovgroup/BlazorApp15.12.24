namespace BlazorAppToDo.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ToDo> ToDoList { get; set; } = new List<ToDo>();
    }
}
