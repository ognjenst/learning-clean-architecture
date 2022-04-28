using LearnCA.Application.TodoLists.Queries.ExportTodos;

namespace LearnCA.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
