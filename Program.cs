using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7___Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> members = new List<string>();
            members = PopulateMembers();
            List<string> foods = new List<string>();
            foods = PopulateFoods();
            List<string> cities = new List<string>();
            cities = PopulateCities();

            string again = "y";
            while (again == "y" || again == "Y")
            {
                int userMember = GetInput(members);
                Console.WriteLine("\nYou are asking for more information about " + members[userMember] + ".");

                int selection = UserInfo(userMember);

                if (selection == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(members[userMember] + " likes " + foods[userMember] + " the best.");
                }
                else if (selection == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine(members[userMember] + " is from " + cities[userMember] + ", originally.");
                }

                Console.Write("\nMore questions? (Y/N): ");
                again = Console.ReadLine();
                Console.WriteLine();
            }
        }

        public static int GetInput(List<string> passedList)
        {
            int x = 0;
            while (x < 1 || x > (passedList.Count))
            {
                Console.Clear();
                Console.WriteLine("\nList of Group Members:\n");
                for (int i = 0; i < passedList.Count; i++)
                {
                    Console.WriteLine((i+1) + ") " + passedList[i]);
                }
                Console.Write($"\nWhich group member would you like to know more about? (Enter a number 1-{passedList.Count}): ");
                x = int.Parse(Console.ReadLine());
            }
            Console.Clear();
            return x-1;
        }

        public static int UserInfo(int indexNumber)
        {
            int selection = 0;
            while (selection != 1 && selection != 2)
            {
                Console.Write("\nWould you like to know:\n\n\t1) Favorite food\n\t2) Hometown\n\nSelection: ");
                selection = int.Parse(Console.ReadLine());
            }
            return selection;
        }

        public static List<string> PopulateMembers()
        {
            List<string> x = new List<string>();

            x.Add("Josh");
            x.Add("Sabrina");
            x.Add("Tori");
            x.Add("Christopher");
            x.Add("Jillane");
            x.Add("Megan");
            x.Add("Ryan");
            x.Add("Diane");
            x.Add("JJ");
            x.Add("Ariana");
            x.Add("Stephani");
            x.Add("Kelsey");
            x.Add("Tommy");
            //x.Add("Added Later");

            //for (int i = 0; i < x.Count; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}

            return x;
        }

        public static List<string> PopulateFoods()
        {
            List<string> x = new List<string>();

            x.Add("apples");
            x.Add("bananas");
            x.Add("clementines");
            x.Add("dreamsicles");
            x.Add("eggs");
            x.Add("French fries");
            x.Add("grapefruit");
            x.Add("hard candy");
            x.Add("ice cream");
            x.Add("jello");
            x.Add("kiwi fruit");
            x.Add("lox");
            x.Add("mangoes");
            //x.Add("added fruit");

            //for (int i = 0; i < x.Count; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}

            return x;
        }

        public static List<string> PopulateCities()
        {
            List<string> x = new List<string>();

            x.Add("Austin");
            x.Add("Boston");
            x.Add("Chicago");
            x.Add("Dallas");
            x.Add("Eaton");
            x.Add("Foxboro");
            x.Add("Georgia");
            x.Add("Houston");
            x.Add("Ipanema");
            x.Add("Jackson");
            x.Add("Kalamazoo");
            x.Add("Logan");
            x.Add("Milwaukee");
            //x.Add("Added City");

            //for (int i = 0; i < x.Count; i++)
            //{
            //    Console.WriteLine(x[i]);
            //}

            return x;
        }
    }
}
