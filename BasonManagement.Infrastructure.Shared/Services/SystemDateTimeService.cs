using BasonManagement.Application.Interfaces.Shared;
using System;

namespace BasonManagement.Infrastructure.Shared.Services
{
    public class SystemDateTimeService : IDateTimeService
    {
        public DateTime NowUtc => DateTime.UtcNow;
    }
}