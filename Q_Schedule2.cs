using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace legacy_service_quarts
{
    class Q_Schedule2
    {
        public static void Start()
        {
            IScheduler scheduler2 = StdSchedulerFactory.GetDefaultScheduler();
            scheduler2.Start();

            IJobDetail job2 = JobBuilder.Create<Q_Process2>().Build();

            ITrigger trigger2 = TriggerBuilder.Create()
              
                 .WithIdentity("trigger2", "group2")
                   .WithCronSchedule("0 16 10 * * ?")
                    .Build();

            scheduler2.ScheduleJob(job2, trigger2);
        }
    }

}
