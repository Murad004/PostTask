#region Admin
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin
{
    class Admin
    {
        public static int id;

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Post.Post[] Posts { get; set; }
        public int PostCount { get; set; }
        public Notification.Notification[] notifications { get; set; }
        public int NotificationCount { get; set; }

        public Admin()
        {
            this.Id = id++;
        }

        public void AddPost(Post.Post newpost)
        {
            Post.Post[] temp = new Post.Post[++PostCount];
            if (Posts != null)
            {
                Posts.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = newpost;
            Posts = temp;
        }

        public void AddNotification(Notification.Notification newnot)
        {
            Notification.Notification[] temp = new Notification.Notification[++NotificationCount];
            if (notifications != null)
            {
                notifications.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = newnot;
            notifications = temp;
        }


        public void ShowPosts()
        {
            foreach (var item in Posts)
            {
                item.Show();
            }
        }
        public void ShowNotifications(int chose)
        {
            foreach (var item in notifications)
            {
                if (chose == 1)
                {
                    if (item.HasRead == true)
                    {
                        item.Show();
                    }
                }
                else if (chose == 2)
                {
                    if (item.HasRead == false)
                    {
                        item.Show();
                        item.HasRead = true;
                    }
                }
            }
        }

    }
}
#endregion