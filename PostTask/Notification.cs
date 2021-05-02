#region Notification
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notification
{
    class Notification
    {
        public static int id;
        public int Id { get; set; }
        public string Text { get; set; }
        public string Datetime { get; set; }
        public UserNamespace.User FromUser { get; set; }
        public bool HasRead { get; set; }


        public Notification()
        {
            this.Id = id++;
        }

        public void Show()
        {
            Console.WriteLine("============Notification INFO================");
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Text : {Text}");
            Console.WriteLine($"Date Time : {Datetime}");
            Console.WriteLine($"From user : {FromUser.Email}");
        }

    }
}
#endregion