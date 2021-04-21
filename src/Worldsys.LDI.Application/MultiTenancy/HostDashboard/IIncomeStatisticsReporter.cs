using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Worldsys.LDI.MultiTenancy.HostDashboard.Dto;

namespace Worldsys.LDI.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}