using LearnCA.Application.Common.Mappings;
using LearnCA.Domain.Entities;

namespace LearnCA.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
