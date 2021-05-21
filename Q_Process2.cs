using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
namespace legacy_service_quarts
{
    public class Q_Process2 : IJob
    {
        public void Execute(IJobExecutionContext context)//
        {
            Q_JOB newjob = new Q_JOB();
            newjob.doBusiness2();
           
        }
    }
}
