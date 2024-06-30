using Microsoft.AspNetCore.Components;
using mojoSMB.Web.Entities;

namespace mojoSMB.Web.Components.Pages;

public partial class Todo : ComponentBase
{
    private string? _newTodo;
    private readonly List<TodoItem> _todos = [];
    
    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(_newTodo))
        {
            _todos.Add(new TodoItem
            {
                Title = _newTodo,
                DateAdded = DateTime.UtcNow
            });
            _newTodo = string.Empty;
        }
        
        // TODO: Consider cleanliness of below
        // if (string.IsNullOrWhiteSpace(_newTodo)) return;
        // _todos.Add(new TodoItem { Title = _newTodo });
        // _newTodo = string.Empty;
    }

}