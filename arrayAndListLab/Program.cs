using System;

namespace arrayAndListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            Console.Write("Welcome to our C# class! ");

            while (repeat)
            {
                Console.Write("Which student would you like to learn more about? (enter a number 1-14): ");
                string value = Console.ReadLine();
                bool success = int.TryParse(value, out int indexNum);

                if (success)
                {
                    if (indexNum > 0 && indexNum <= 14)
                    {
                        //split first and last name
                        string[] bothNames = StudentName(indexNum).Split(" ");
                        Console.Write($"Student {indexNum} is {StudentName(indexNum)}. What would you like to know about {bothNames[0]}? (enter \"hometown\" or \"favorite food\"): ");
                        string infoAnswer = Console.ReadLine();

                        while (true)
                        {
                            infoAnswer = infoAnswer.ToLower();

                            if (infoAnswer == "hometown")
                            {
                                Console.Write($"{bothNames[0]} is from {StudentInfo(indexNum, infoAnswer)}. ");
                                break;
                            }
                            else if (infoAnswer == "favorite food")
                            {
                                Console.Write($"{bothNames[0]}'s favorite food is {StudentInfo(indexNum, infoAnswer)}. ");
                                break;
                            }
                            else
                            {
                                Console.Write("\nInvalid input. Try again. Please enter \"hometown\" or \"favorite food\"): ");
                                infoAnswer = Console.ReadLine();
                            }
                        }

                        while (true)
                        {
                            Console.Write("Would you like to know more? (y/n): ");
                            string moreInfo = Console.ReadLine();

                            if (moreInfo == "y" && infoAnswer == "hometown")
                            {
                                Console.WriteLine($"{ bothNames[0]}'s favorite food is {StudentInfo(indexNum, "favorite food")}. ");
                                break;
                            }
                            else if (moreInfo == "y" && infoAnswer == "hometown")
                            {
                                Console.Write($"{bothNames[0]} is from {StudentInfo(indexNum, infoAnswer)}. ");
                                break;
                            }
                            else if (moreInfo == "n")
                            {
                                Console.WriteLine("Okay, thanks!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Try again.");
                            }
                        }

                        while (true)
                        {
                            Console.Write("Would you like to learn about another student? (y/n): ");
                            string answer = Console.ReadLine();

                            if (answer == "n")
                            {
                                Console.WriteLine("\nGoodbye!");
                                repeat = false;
                                break;
                            }
                            else if (answer == "y")
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("\nInvalid input. Try again.\n");
                            }
                        }
                    }

                    else
                    {
                        Console.WriteLine("Invalid input. Try again.\n");
                    }
                }

                else
                {
                    Console.WriteLine("\nInvalid input. Try again. Enter a number 1-14: ");
                }
            }
        }

        public static string StudentName(int num)
        {
            string[] names = {
                "Justin Jones",
                "Matt Bye",
                "Logan Harris",
                "Raston Gillbert",
                "Yousif Beeai",
                "Yash Majalikar",
                "Chris Paul",
                "Radeen Ahmed",
                "Josh Carolin",
                "Aron Gibson",
                "Kasean Barber",
                "Scott Thayer",
                "Delmar Presley",
                "Brandon Pietryka"
            };

            return names[num - 1];
        }

        public static string StudentInfo(int num, string info)
        {
            string[,] infoArray =
            {
                { "Wyoming, MI", "Baja Blast" },
                { "Flint, MI", "Hot Wings" },
                { "Plymouth, MI", "Funyuns" },
                { "Zeeland, MI", "Vanilla Instant Pudding" },
                { "Oak Park, MI", "Deep Dish Pizza" },
                { "Detroit, MI", "Maggi Noodles" },
                { "Novi, MI", "Tacos" },
                { "Warren, MI", "Mexican" },
                { "Northville, MI", "Nalesniki" },
                { "Berea, KY", "Sushi" },
                { "Detroit, MI", "Steak" },
                { "Lansing, MI", "Nashville Chicken" },
                { "Detroit, MI", "Vietnamese Food" },
                { "Novi, MI", "Sushi" }
            };

            info = info.ToLower();

                if (info == "hometown")
                {
                    return infoArray[num - 1, 0];
                }
                else
                {
                    return infoArray[num - 1, 1];
                }
        }
    }
}