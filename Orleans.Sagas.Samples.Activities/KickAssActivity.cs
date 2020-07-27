﻿using Orleans.Runtime;
using System;
using System.Threading.Tasks;

namespace Orleans.Sagas.Samples.Activities
{
    public class KickAssActivity : Activity<KickAssConfig>
    {
        public override Task Execute(IActivityContext context)
        {
            //Logger.Info($"Kicking ass {Config.KickAssCount} times...");
            for (int i = 0; i < Config.KickAssCount; i++)
            {
                //Logger.Info("Ass kicked.");
            }
            return Task.CompletedTask;
        }

        public override Task Compensate(IActivityContext context)
        {
            return Task.CompletedTask;
        }
    }
}
