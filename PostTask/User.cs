#region User
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserNamespace
{
    class User
    {

        public static int id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User()
        {
            this.Id = id++;
        }


        public void WriteNotification(Admin.Admin admin, Notification.Notification newnot)
        {
            admin.AddNotification(newnot);
        }

        public void showPost(Admin.Admin[] admins)
        {
            foreach (var admin in admins)
            {
                if (admin.Posts != null)
                {

                    admin.ShowPosts();

                    foreach (var post in admin.Posts)
                    {
                        post.ViewCount++;
                    }
                    likePost(admins);
                }
            }
            throw new Exception("There is no other post.");
        }

        public void likePost(Admin.Admin[] admins)
        {
            Console.Write("Do you want to like it : ");
            string choslike = Console.ReadLine();
            if (choslike == "yes")
            {
                Console.Write("ID : ");
                int.TryParse(Console.ReadLine(), out int id);
                foreach (var admin in admins)
                {
                    foreach (var post in admin.Posts)
                    {
                        if (id == post.Id)
                        {
                            post.LikeCount++;
                        }

                    }
                }
            }
            else if (choslike == "no")
            {
                Console.WriteLine("\n\n\n");
                Console.Clear();
            }
        }

    }
}
#endregion