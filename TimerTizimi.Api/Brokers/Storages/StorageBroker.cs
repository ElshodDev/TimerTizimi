//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: TimerTizimi.Api
//===================================================

using Microsoft.EntityFrameworkCore;
using TimerTizimi.Api.Models.Foundations.Timers;

namespace TimerTizimi.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<TimerEntity> Timers { get; set; }
    }
}
