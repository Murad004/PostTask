using PostTask;
using System;
using System.Collections.Generic;
using System.Linq;
#region Program
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace PostTask
{
    class Program
    {

        static void Main(string[] args)
        {
            WorkMenu.Workmenu.Start();
            //SendEmail.SendMail();
        }
    }
}
#endregion