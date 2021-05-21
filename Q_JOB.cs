using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace legacy_service_quarts
{
    public class Q_JOB
    {
        public void doBusiness()
        {
           
            lock (BusinessLock.LockObj)
            {
                try
                {
                   
                    //your operation task
                }
                catch (Exception ex)
                {
                 
                }
            }
       
        }

       

   

       
      


       

    
    }
}
