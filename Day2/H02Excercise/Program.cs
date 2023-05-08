using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H02Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Friend> friends = new List<Friend>();

            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Birthday Reminder ===");
                Console.WriteLine("1. Add friend");
                Console.WriteLine("2. Edit friend");
                Console.WriteLine("3. Delete friend");
                Console.WriteLine("4. View friends");
                Console.WriteLine("5. Check for upcoming birthdays");
                Console.WriteLine("6. Exit");
                Console.Write("Select an option: ");

                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddFriend(friends);
                        break;
                    case 2:
                        EditFriend(friends);
                        break;
                    case 3:
                        DeleteFriend(friends);
                        break;
                    case 4:
                        ViewFriends(friends);
                        break;
                    case 5:
                        CheckUpcomingBirthdays(friends);
                        break;
                    case 6:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Press any key to try again...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void AddFriend(List<Friend> friends)
        {
            Console.Clear();
            Console.WriteLine("=== Add Friend ===");

            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter birthdate (dd/mm/yyyy): ");
            string birthdate = Console.ReadLine();

            Friend friend = new Friend(name, birthdate);
            friends.Add(friend);

            Console.WriteLine("Friend added. Press any key to continue...");
            Console.ReadKey();
        }

        static void EditFriend(List<Friend> friends)
        {
            Console.Clear();
            Console.WriteLine("=== Edit Friend ===");

            Console.Write("Enter name of friend to edit: ");
            string name = Console.ReadLine();

            Friend friend = friends.Find(f => f.Name == name);

            if (friend != null)
            {
                Console.Write("Enter new birthdate (dd/mm/yyyy): ");
                string birthdate = Console.ReadLine();

                friend.birthdate = birthdate;

                Console.WriteLine("Friend edited. Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Friend not found. Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void DeleteFriend(List<Friend> friends)
        {
            Console.Clear();
            Console.WriteLine("=== Delete Friend ===");

            Console.Write("Enter name of friend to delete: ");
            string name = Console.ReadLine();

            Friend friend = friends.Find(f => f.Name == name);

            if (friend != null)
            {
                friends.Remove(friend);

                Console.WriteLine("Friend deleted. Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Friend not found. Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void ViewFriends(List<Friend> friends)
        {
            Console.Clear();
            Console.WriteLine("=== View Friends ===");

            if (friends.Count == 0)
            {
                Console.WriteLine("No friends found. Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                foreach (Friend friend in friends)
                {
                    Console.WriteLine($"Name: {friend.Name}, Birthdate: {friend.Birthdate}");
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        static void CheckUpcomingBirthdays(List<Friend> friends)
        {
            // Get the current date and time
            DateTime now = DateTime.Now;
            // Get the upcoming birthdays within the next 7 days
            List<Friend> upcomingBirthdays = friends.Where(f => f.Birthday.Date >= now.Date && f.Birthday.Date <= now.AddDays(7).Date).ToList();

            // Notify the user of the upcoming birthdays
            if (upcomingBirthdays.Count > 0)
            {
                Console.WriteLine("\nUpcoming birthdays:");
                foreach (Friend friend in upcomingBirthdays)
                {
                    int daysUntilBirthday = (friend.Birthday.Date - now.Date).Days;
                    string birthdayMessage = String.Format("{0} ({1}), in {2} days", friend.Name, friend.Birthday.ToString("d"), daysUntilBirthday);
                    Console.WriteLine(birthdayMessage);
                }
            }
            else
            {
                Console.WriteLine("\nThere are no upcoming birthdays within the next 7 days.");
            }
        }
    }

    class Friend
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }

    
}
