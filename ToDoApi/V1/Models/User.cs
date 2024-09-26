namespace ToDoApi.V1.Models
{
    public class User {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string[] Roles { get; set; } = [];
        public ICollection<ToDo> ToDos { get; set; } = [];
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
