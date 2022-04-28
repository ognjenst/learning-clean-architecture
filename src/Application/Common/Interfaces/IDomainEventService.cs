using LearnCA.Domain.Common;

namespace LearnCA.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
