using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Worldsys.LDI.EntityFrameworkCore;

namespace Worldsys.LDI.HealthChecks
{
    public class LDIDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public LDIDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("LDIDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("LDIDbContext could not connect to database"));
        }
    }
}
