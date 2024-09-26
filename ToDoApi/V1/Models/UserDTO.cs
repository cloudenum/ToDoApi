namespace ToDoApi.V1.Models
{
    public class UserDTO
    {
        public UserDTO()
        {
            ToDos = [];
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public IList<ToDo> ToDos { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
