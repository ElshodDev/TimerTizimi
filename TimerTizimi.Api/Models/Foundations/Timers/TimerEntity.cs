//===================================================
// Copyright (c) 2025 Elshod Ibadullayev
// Free To Use For Learning and Development
// Project: TimerTizimi.Api
//===================================================

namespace TimerTizimi.Api.Models.Foundations.Timers
{
    public class TimerEntity
    {
        public Guid Id { get; set; }= Guid.NewGuid();
        public DateTime StartTime { get; set; }= DateTime.Now;
        public DateTime EndTime { get; set; }= DateTime.UtcNow;
        public TimeSpan Duration { get; set; }= TimeSpan.Zero;
    }
}
