﻿using System.Threading.Tasks;

namespace Orleans.Sagas.Samples.Activities
{
    public class BookHotelActivity : IActivity
    {
        public Task Compensate(IActivityContext context)
        {
            return Task.CompletedTask;
        }

        public Task Execute(IActivityContext context)
        {
            return Task.CompletedTask;
        }
    }
}
