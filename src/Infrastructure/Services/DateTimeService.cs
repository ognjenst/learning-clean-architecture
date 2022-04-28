using LearnCA.Application.Common.Interfaces;

namespace LearnCA.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
