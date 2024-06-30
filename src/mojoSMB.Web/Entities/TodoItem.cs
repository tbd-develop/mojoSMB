namespace mojoSMB.Web.Entities;

public class TodoItem
{
    public int UserId { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public DateTime DateAdded { get; set; }
    public DateTime? DueDateTime { get; set; }
    public bool IsDone { get; set; }
}