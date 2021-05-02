#region WorkMenu
using PostTask;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WorkMenu
{
    using u = UserNamespace;
    using a = Admin;
    using n = Notification;
    using p = Post;
    class Workmenu
    {

        public static void adminMenu(a.Admin[] admins, u.User[] users)
        {
            bool ad = true;
            while (ad)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Username : ");
                string adminusername = Console.ReadLine();
                Console.Write("Password : ");
                string adminpassword = Console.ReadLine();
                foreach (var admin in admins)
                {

                    try
                    {
                        if (Helper.CheckedAdmin(admins,adminusername,adminpassword))
                        {
                            Console.Clear();
                            ad = false;
                            bool exit = true;
                            while (exit)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Add post (1)");
                                Console.WriteLine("Show notification (2)");
                                Console.WriteLine("Show post (3)");
                                Console.WriteLine("Exit profil (4)");
                                Console.Write("You choose : ");
                                int.TryParse(Console.ReadLine(), out int chooseAdminFunction);
                                if (chooseAdminFunction == 1)
                                {
                                    Console.Clear();
                                    Console.Write("Content : ");
                                    string content = Console.ReadLine();
                                    p.Post newp = new p.Post { Content = content, LikeCount = 0, ViewCount = 0 };
                                    admin.AddPost(newp);
                                    Console.Clear();
                                    Console.WriteLine("\n\n");
                                }
                                else if (chooseAdminFunction == 2)
                                {
                                    Console.WriteLine("Read (1)");
                                    Console.WriteLine("Not read (2)");
                                    Console.Write("You choose : ");
                                    int.TryParse(Console.ReadLine(), out int chose);
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    admin.ShowNotifications(chose);
                                    Console.WriteLine("\n\n");

                                }
                                else if (chooseAdminFunction == 3)
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    admin.ShowPosts();
                                    Console.WriteLine("\n\n");
                                }
                                else if (chooseAdminFunction == 4)
                                {
                                    Console.Clear();
                                    exit = false;
                                    adminoruser();
                                    int.TryParse(Console.ReadLine(), out int thrchose);
                                    if (thrchose == 1)
                                    {
                                        adminMenu(admins, users);
                                    }
                                    else if (thrchose == 2)
                                    {
                                        userMenu(users, admins);
                                    }
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                }

            }
        }
        public static void userMenu(u.User[] users, a.Admin[] admins)
        {
            bool us = true;
            while (us)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("E-Mail : ");
                string useremail = Console.ReadLine();
                Console.Write("Password : ");
                string userpassword = Console.ReadLine();
                foreach (var user in users)
                {

                    try
                    {
                        if (Helper.CkeckedUser(users,useremail,userpassword))
                        {
                            Console.Clear();
                            us = false;
                            bool usexit = true;
                            while (usexit)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Add not (1)");
                                Console.WriteLine("Show Posts (2)");
                                Console.WriteLine("Exit (3)");
                                Console.WriteLine("You choose : ");
                                int.TryParse(Console.ReadLine(), out int usFunction);
                                if (usFunction == 1)
                                {
                                    Console.Write("Text : ");
                                    string text = Console.ReadLine();
                                    n.Notification newnot = new n.Notification
                                    {
                                        Text = text,
                                        FromUser = user,
                                        HasRead = false,
                                        Datetime = DateTime.Now.ToLongTimeString()
                                    };

                                    Console.Write("Which admin : ");
                                    string username = Console.ReadLine();
                                    foreach (var admin in admins)
                                    {
                                        if (username == admin.Username)
                                        {
                                            admin.AddNotification(newnot);
                                            Console.Clear();
                                        }
                                    }
                                }
                                else if (usFunction == 2)
                                {
                                    try
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                        user.showPost(admins);
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }

                                }
                                else if (usFunction == 3)
                                {
                                    Console.Clear();
                                    usexit = false;
                                    adminoruser();
                                    int.TryParse(Console.ReadLine(), out int twochose);
                                    Console.Clear();
                                    if (twochose == 1)
                                    {
                                        adminMenu(admins, users);
                                    }
                                    else if (twochose == 2)
                                    {
                                        userMenu(users, admins);
                                    }
                                }
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                }

            }
        }

        private static void adminoruser()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Admin (1)");
            Console.WriteLine("User (2)");
            Console.Write("You : ");
        }
        public static void Start()
        {
            u.User user1 = new u.User
            {
                Name = "Murad",
                Surname = "Sadixov",
                Age = 16,
                Email = "sadixovmurad322@gmail.com",
                Password = "murad123"
            };
            u.User user2 = new u.User
            {
                Name = "Elxan",
                Surname = "Atayev",
                Age = 15,
                Email = "atayevelxan32@gmail.com",
                Password = "elxan123"
            };
            u.User user3 = new u.User
            {
                Name = "Eli",
                Surname = "Ibadzade",
                Age = 15,
                Email = "ibadzadeeli32@gmail.com",
                Password = "eli123"
            };

            u.User[] users = new u.User[3] { user1, user2, user3 };

            

            a.Admin admin1 = new a.Admin
            {
                Username = "johnjohn",
                Email = "johnjohnlu122@gmail.com",
                Password = "john123",
            };
            a.Admin admin2 = new a.Admin
            {
                Username = "mikemike",
                Email = "mikeehmedli34@gmail.com",
                Password = "mike123",
            };
            a.Admin[] admins = new a.Admin[2] { admin1, admin2 };

            adminoruser();
            bool isint = int.TryParse(Console.ReadLine(), out int choose);
            Console.Clear();
            if (choose == 1)
            {
                adminMenu(admins, users);
            }
            else if (choose == 2)
            {
                userMenu(users, admins);
            }
        }
    }
}
#endregion