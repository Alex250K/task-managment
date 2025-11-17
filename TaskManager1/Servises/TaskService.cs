

using Microsoft.JSInterop;
using System.Text.Json;
using TaskManager1;

public class TaskService
{
    private readonly IJSRuntime _jsRuntime;
    private readonly JsonSerializerOptions _options = new JsonSerializerOptions
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };

    public TaskService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    /// <summary>
    /// Carga las tareas desde localStorage.
    /// </summary>
    public async Task<List<TodoItem>> LoadTasksAsync()
    {
        var storedTasks = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "tasks");
        return string.IsNullOrEmpty(storedTasks)
            ? new List<TodoItem>()
            : JsonSerializer.Deserialize<List<TodoItem>>(storedTasks, _options) ?? new List<TodoItem>();
    }

    /// <summary>
    /// Guarda las tareas en localStorage.
    /// </summary>
    public async Task SaveTasksAsync(List<TodoItem> tasks)
    {
        var json = JsonSerializer.Serialize(tasks, _options);
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "tasks", json);
    }
}
