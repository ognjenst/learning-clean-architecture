using LearnCA.Application.Common.Exceptions;
using LearnCA.Application.TodoLists.Commands.CreateTodoList;
using LearnCA.Application.TodoLists.Commands.DeleteTodoList;
using LearnCA.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

namespace LearnCA.Application.IntegrationTests.TodoLists.Commands;

using static Testing;

public class DeleteTodoListTests : TestBase
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand { Id = 99 };
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand
        {
            Id = listId
        });

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
