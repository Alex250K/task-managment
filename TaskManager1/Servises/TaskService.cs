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

    private List<TodoItem> _tasks = new();
    public IReadOnlyList<TodoItem> Tasks => _tasks.AsReadOnly();

    public event Action? OnChange;

    public TaskService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task InitializeAsync()
    {
        _tasks = await LoadTasksFromStorageAsync();
        NotifyStateChanged();
    }

    private async Task<List<TodoItem>> LoadTasksFromStorageAsync()
    {
        try
        {
            var storedTasks = await _jsRuntime.InvokeAsync<string>("localStorage.getItem", "tasks");
            return string.IsNullOrEmpty(storedTasks)
                ? new List<TodoItem>()
                : JsonSerializer.Deserialize<List<TodoItem>>(storedTasks, _options) ?? new List<TodoItem>();
        }
        catch
        {
            return new List<TodoItem>();
        }
    }

    public async Task AddTaskAsync(TodoItem task)
    {
        _tasks.Add(task);
        await SaveTasksToStorageAsync();
        NotifyStateChanged();
    }

    public async Task UpdateTaskAsync(TodoItem task)
    {
        var index = _tasks.FindIndex(t => t.CreatedAt == task.CreatedAt); // Assuming CreatedAt is unique enough for now, or use ID if available
        if (index != -1)
        {
            _tasks[index] = task;
            await SaveTasksToStorageAsync();
            NotifyStateChanged();
        }
    }
    
    public async Task ReplaceTasksAsync(List<TodoItem> newTasks)
    {
        _tasks = newTasks;
        await SaveTasksToStorageAsync();
        NotifyStateChanged();
    }

    public async Task DeleteTaskAsync(TodoItem task)
    {
        _tasks.Remove(task);
        await SaveTasksToStorageAsync();
        NotifyStateChanged();
    }

    private async Task SaveTasksToStorageAsync()
    {
        var json = JsonSerializer.Serialize(_tasks, _options);
        await _jsRuntime.InvokeVoidAsync("localStorage.setItem", "tasks", json);
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
    
    // Keep original method for compatibility if needed, but redirect to internal state
    public async Task<List<TodoItem>> LoadTasksAsync()
    {
        if (_tasks.Count == 0)
        {
            await InitializeAsync();
        }
        return _tasks;
    }

    public async Task SaveTasksAsync(List<TodoItem> tasks)
    {
        await ReplaceTasksAsync(tasks);
    }
}
