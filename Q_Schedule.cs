using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace legacy_service_quarts
{
    class Q_Schedule
    {

      

        public static void Start()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            IJobDetail job = JobBuilder.Create<Q_Process>().Build();

            ITrigger trigger = TriggerBuilder.Create()
              
                 .WithIdentity("trigger1", "group1")
                   .WithCronSchedule("0 0 23 L * ?")   //11 PM every last day of the month
                    .Build();

            scheduler.ScheduleJob(job, trigger);
           
        }
    }

}
