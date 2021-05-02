#region Post
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    class Post
    {

        public static int id;


        public int Id { get; set; }
        public string Content { get; set; }
        public string CreationDateTime = DateTime.Now.ToLongTimeString();
        public int LikeCount { get; set; }
        public int ViewCount { get; set; }

        public Post()
        {
            this.Id = id++;
        }

        public void Show()
        {
            Console.WriteLine("+++++++++++Post INFO+++++++++++");
            Console.WriteLine($"ID : {Id}");
            Console.WriteLine($"Content : {Content}");
            Console.WriteLine($"Date Time : {CreationDateTime}");
            Console.WriteLine($"Like count : {LikeCount}");
            Console.WriteLine($"View count : {ViewCount}");
        }

    }
}
#endregion