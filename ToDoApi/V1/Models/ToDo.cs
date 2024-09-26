using Microsoft.Build.Framework;

namespace ToDoApi.V1.Models
{
    public class ToDo(string name)
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = name;
        public string? Description { get; set; }
        public ToDoStatus Status { get; set; } = ToDoStatus.Pending;
        public User User { get; set; } = null!;
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }
    }

    public enum ToDoStatus
    {
        Pending,
        InProgress,
        Completed,
        Archived
    }
}
