using System.Globalization;
using System;
using System.Net;
using System.Net.Mail;

using INSTAGRAM;

Console.WriteLine("Welcome!!!");

POST post1 = new("Today Messi Scored 2 Goals Against Real Madrid", DateTime.Now, 0, 0);
POST post2 = new("Sergio Ramos got emotional on his Sevilla homecoming ", DateTime.Now, 0, 0);
POST post3 = new("Marcus Rashford not been included in Ballon d'Or nominee list ", DateTime.Now, 0, 0);
POST[] posts = new POST[] { post1, post2, post3 };

USER[] users = new USER[] { };

ADMIN admin1 = new("gasimovcavid777@gmail.com", "cavid2004", posts, users);

while (true)
{
    ConsoleKeyInfo key;
    int choice = 1;
    bool isSelected = false;
    (int left, int top) = Console.GetCursorPosition();
    string color = "\u001b[32m";

    Console.CursorVisible = true;

    while (!isSelected)
    {
        Console.SetCursorPosition(left, top);
        Console.WriteLine($"{(choice == 1 ? color : "")}Admin\u001b[0m");
        Console.WriteLine($"{(choice == 2 ? color : "")}User\u001b[0m");

        key = Console.ReadKey(true);

        switch (key.Key)
        {
            case ConsoleKey.DownArrow:
                choice = (choice == 2 ? 1 : choice + 1);
                break;

            case ConsoleKey.UpArrow:
                choice = (choice == 1 ? 2 : choice - 1);
                break;

            case ConsoleKey.Enter:
                isSelected = true;
                break;
        }
    }

    if (choice == 1)
    {
        Console.WriteLine("You choose admin");
    }

    else if (choice == 2)
    {
        Console.WriteLine("You choose user");
    }

    if (choice == 1)
    {
        string enter_admin_name;
        Console.Write("Enter admin mail: ");
        enter_admin_name = Console.ReadLine();

        string enter_admin_password;
        Console.Write("Enter admin password: ");
        enter_admin_password = Console.ReadLine();

        if ((enter_admin_name == "gasimovcavid777@gmail.com") && (enter_admin_password == "cavid2004"))
        {
            Console.WriteLine("You entered as CAVID");
            Console.Clear();
            bool isSelected_1 = false;
            int choice_1 = 1;
            string color_1 = "\u001b[32m";

            while (!isSelected_1)
            {
                Console.SetCursorPosition(left, top);
                Console.WriteLine($"{(choice_1 == 1 ? color_1 : "")}Look at posts\u001b[0m");
                Console.WriteLine($"{(choice_1 == 2 ? color_1 : "")}Look at users\u001b[0m");
                Console.WriteLine($"{(choice_1 == 3 ? color_1 : "")}Add post\u001b[0m");
                Console.WriteLine($"{(choice_1 == 4 ? color_1 : "")}Delete post\u001b[0m");

                key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.DownArrow:
                        choice_1 = (choice_1 == 4 ? 1 : choice_1 + 1);
                        break;

                    case ConsoleKey.UpArrow:
                        choice_1 = (choice_1 == 1 ? 4 : choice_1 - 1);
                        break;

                    case ConsoleKey.Enter:
                        isSelected_1 = true;
                        break;
                }
            }

            if (choice_1 == 1)
            {
                Console.WriteLine("You selected looking posts");
                Console.Clear();

                if (posts.Length == 0)
                {
                    Console.WriteLine("NO POSTS");
                }

                else
                {
                    for (int i = 0; i < admin1.posts.Length; i++)
                    {
                        admin1.posts[i].showAllPost();
                    }
                }
            }

            else if (choice_1 == 2)
            {
                Console.WriteLine("You selected looking users");
                Console.Clear();

                if (users.Length == 0)
                {
                    Console.WriteLine("NO USERS");
                }

                else
                {
                    for (int i = 0; i < admin1.users.Length; i++)
                    {
                        admin1.users[i].showAllUser();
                    }
                }
            }

            else if (choice_1 == 3)
            {
                Console.WriteLine("You selected adding post");
                Console.Clear();

                Array.Resize(ref admin1.posts, (admin1.posts.Length + 1));

                Console.Write("Add content: ");
                string add_content = Console.ReadLine();
                admin1.posts[admin1.posts.Length - 1] = new POST();
                admin1.posts[admin1.posts.Length - 1].Content = add_content;
                admin1.posts[admin1.posts.Length - 1].Id = Guid.NewGuid();
                admin1.posts[admin1.posts.Length - 1].CreationDateTime = DateTime.Now;
                admin1.posts[admin1.posts.Length - 1].LikeCount = 0;
                admin1.posts[admin1.posts.Length - 1].ViewCount = 0;
            }

            else if (choice_1 == 4)
            {
                Console.WriteLine("You selected deleting post");
                Console.Clear();

                Console.Write("Enter the Id: ");
                string guid_ = Console.ReadLine();
                Guid guid = new Guid(guid_);

                for (int i = 0; i < admin1.posts.Length; i++)
                {
                    if (admin1.posts[i].Id == guid)
                    {
                        for (int j = i; j < admin1.posts.Length - 1; j++)
                        {
                            admin1.posts[j] = admin1.posts[j + 1];
                        }
                        Array.Resize(ref admin1.posts, admin1.posts.Length - 1);
                    }
                }



            }
        }
    }

    else if (choice == 2)
    {
        Console.Clear();
        bool isSelected_1 = false;
        int choice_1 = 1;
        string color_1 = "\u001b[32m";

        while (!isSelected_1)
        {
            Console.SetCursorPosition(left, top);
            Console.WriteLine($"{(choice_1 == 1 ? color_1 : "")}Sign in\u001b[0m");
            Console.WriteLine($"{(choice_1 == 2 ? color_1 : "")}Sign up\u001b[0m");

            key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.DownArrow:
                    choice_1 = (choice_1 == 2 ? 1 : choice_1 + 1);
                    break;

                case ConsoleKey.UpArrow:
                    choice_1 = (choice_1 == 1 ? 2 : choice_1 - 1);
                    break;

                case ConsoleKey.Enter:
                    isSelected_1 = true;
                    break;
            }
        }

        if (choice_1 == 1)
        {
            Console.Write("Enter Username: ");
            string enter_username = Console.ReadLine();

            Console.Write("Enter Password: ");
            string enter_user_password = Console.ReadLine();

            for (int i = 0; i < admin1.users.Length; i++)
            {
                if ((enter_username == admin1.users[i].Email) && (enter_user_password == admin1.users[i].Password))
                {
                    for (int k = 0; k < admin1.posts.Length; k++)
                    {
                        admin1.posts[k].showAllPost();

                        bool isSelected_2 = false;
                        int choice_2 = 1;
                        string color_2 = "\u001b[32m";

                        while (!isSelected_2)
                        {
                            Console.SetCursorPosition(left, top);
                            Console.WriteLine($"{(choice_2 == 1 ? color_2 : "")}Pass\u001b[0m");
                            Console.WriteLine($"{(choice_2 == 2 ? color_2 : "")}Like\u001b[0m");

                            key = Console.ReadKey(true);

                            switch (key.Key)
                            {
                                case ConsoleKey.DownArrow:
                                    choice_2 = (choice_2 == 2 ? 1 : choice_2 + 1);
                                    break;

                                case ConsoleKey.UpArrow:
                                    choice_2 = (choice_2 == 1 ? 2 : choice_2 - 1);
                                    break;

                                case ConsoleKey.Enter:
                                    isSelected_1 = true;
                                    break;
                            }
                        }

                        if (choice_2 == 1)
                        {
                            admin1.posts[k].ViewCount += 1;
                        }

                        else if (choice_2 == 2)
                        {
                            admin1.posts[k].ViewCount += 1;
                            admin1.posts[k].LikeCount += 1;
                        }
                    }
                }   
            }
        }

        else if (choice_1 == 2)
        {
            Random rand = new Random();
            int random = rand.Next(100000, 999999);

            Console.Write("Enter your Name: ");
            string username = Console.ReadLine();

            Console.Write("Enter your Surname: ");
            string usersurname = Console.ReadLine();

            Console.Write("Enter your Age: ");
            string user_age = Console.ReadLine();
            int userage = Convert.ToInt32(user_age);

            Console.Write("Enter your Mail: ");
            string usermail = Console.ReadLine();

            Console.Write("Enter Password: ");
            string userpassword = Console.ReadLine();

            

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("projectproject611@gmail.com", "xwuv uauv jljd cyni"),
                EnableSsl = true
            };

            var mailMessage = new MailMessage
            {
                From = new MailAddress("projectproject611@gmail.com"),
                Subject = "INSTAGRAM REGISTRATION",
                Body =random.ToString()
            };

            mailMessage.To.Add(usermail);
            smtpClient.Send(mailMessage);

            Console.Write("Enter 6 digit number: ");
            string enter_num = Console.ReadLine();

            if (enter_num==random.ToString())
            {
                Console.Write("You are Registering");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1500);
                }
                Console.WriteLine();

                USER user = new USER(username,usersurname,userage,usermail,userpassword);
                admin1.users.Append(user);
            }

            Console.Clear();
        }
    }
}