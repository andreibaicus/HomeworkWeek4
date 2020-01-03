using BoardLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HomeworkWeek4
{
    class Program
    {
        private static Board board = new Board();

        private static void DisplayMenu()
        {
            Console.WriteLine("1-Afiseaza toate posturile");
            Console.WriteLine("2-Creare post nou");
            Console.WriteLine("3-Stergere post");
            Console.WriteLine("4-Adauga user nou");
            Console.WriteLine("5-Get Users");
            Console.WriteLine("6-Exit");
        }

        private static void DisplayAllPost()
        {
            Console.WriteLine("Posturi:");
            board.getPosts();
        }

        private static void AddPost()
        {
            Console.WriteLine("Text:");
            string textPost = Console.ReadLine();

            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            Console.Write("Data (yyyy): ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Luna (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Ziua (1-31): ");
            int day = int.Parse(Console.ReadLine());

            board.addPost(textPost, email, new DateTime(year, month, day));
        }

        private static void DeletePost()
        {

        }

        private static void AddUser()
        {
            Console.WriteLine("Email:");
            string email = Console.ReadLine();

            Console.WriteLine("Nume:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Prenume:");
            string lastName = Console.ReadLine();

            Console.Write("Anul nasterii (yyyy): ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Luna (1-12): ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Ziua (1-31): ");
            int day = int.Parse(Console.ReadLine());

            board.addUser(email, firstName, lastName, new DateTime(year, month, day));
        }
        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                Console.Write("Optiunea: ");
                int option = 0;
                int.TryParse(Console.ReadLine(), out option);

                Console.WriteLine();

                switch (option)
                {
                    case 1:
                        DisplayAllPost();
                        break;
                    case 2:
                        AddPost();
                        break;
                    case 3:
                        DeletePost();
                        break;
                    case 4:
                        AddUser();
                        break;
                    case 5:
                        board.getUsers();
                        break;
                    case 6:
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again!");
                        break;
                }

                Console.WriteLine();
            }
            //User admin = new User("admin@gmail.com", "Admin", "LAdmin", new DateTime(1991, 11, 13));
            //User andrei = new User("andrei@yahoo.com", "Baicus", "Andrei", new DateTime(1996, 03, 15));
            //board.addPost("khjkj", admin, DateTime.Today);
            //board.addPost("assda", andrei, new DateTime(2019, 12, 28, 10, 35, 0));
            //board.addPost("miininjnijn", andrei, DateTime.UtcNow);
            //board.addPost("nmmm", admin, new DateTime(2000, 12, 28, 10, 35, 0));

            //board.getPosts();
        }
    }
}
