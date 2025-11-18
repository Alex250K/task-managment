
public class TodoItem
{
    public long Id { get; set; } = DateTimeOffset.Now.ToUnixTimeMilliseconds();
    public string Title { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending";
    public string UserName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public string Importance { get; set; } = "Media"; // Alta, Media, Baja
}