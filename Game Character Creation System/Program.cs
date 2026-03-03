using System.ComponentModel.DataAnnotations;

namespace Game_Character_Creation_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            bool working = true;
            while (working)
            {
                Console.WriteLine("\nCHARACTER CREATION MENU!");
                Console.WriteLine("1. Create New Character");
                Console.WriteLine("2. View All Characters");
                Console.WriteLine("3. Search Character Records");
                Console.WriteLine("4. Display Summary Statistics");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        characters.Add(CreateCharacter());
                        Console.WriteLine("Character created Successfully!");
                        break;
                    case "2":
                        ViewAllRecords(characters);
                        break;
                    case "3":
                        SearchRecords(characters);
                        break;
                    case "4":
                        DisplaySummary(characters);
                        break;
                    case "5":
                        working = false;
                        Console.WriteLine("Menu Program Ended");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice, please TRY AGAIN. Choose between 1 and 4)");
                        break;
                }
            }
        }
        static Character CreateCharacter()
        {
            Console.WriteLine("\nCreating NEW Character:");
            Console.Write("\nEnter User's Name: ");
            string userName = Console.ReadLine();
            Console.Write("Enter Character's Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Race: ");
            string race = Console.ReadLine();
            Console.Write("Enter Class: ");
            string characterClass = Console.ReadLine();
            Console.Write("Enter Role: ");
            string role = Console.ReadLine();
            Console.Write("Enter Alignment: ");
            string alignment = Console.ReadLine();
            Console.Write("Enter Weapon Choice: ");
            string weaponChoice = Console.ReadLine();

            int level = ReadInt("Enter Level: ");
            int strength = ReadInt("Enter strength: ");
            int intelligence = ReadInt("Enter intelligence: ");
            int vitality = ReadInt("Enter vitality: ");
            int charisma = ReadInt("Enter charisma: ");
            int dexterity = ReadInt("Enter dexterity: ");
            int wisdom = ReadInt("Enter wisdom: ");
            int luck = ReadInt("Enter luck: ");
            int completedQuests = ReadInt("Enter Completed Quests: ");

            bool isMagicUser = ReadBool("Are you a Magic User? (true/false): ");
            bool isRanged = ReadBool("Are you a Ranged fighter? (true/false): ");
            bool isGuildMember = ReadBool("Are you a Guild Member? (true/false): ");
            bool hasCompanion = ReadBool("Do you have a Companion? (true/false): ");

            int difficultLevel = ReadInt("Enter Difficulty Level: ");
            int experienceLevel = ReadInt("Enter your experience Level: ");

            return new Character(
                userName,
                name,
                race,
                characterClass,
                role,
                alignment,
                weaponChoice,
                level,
                strength,
                intelligence,
                vitality,
                charisma,
                dexterity,
                wisdom,
                luck,
                completedQuests,
                isMagicUser,
                isRanged,
                isGuildMember,
                difficultLevel,
                experienceLevel,
                hasCompanion
            );
        }
        static void ViewAllRecords(List<Character> characters)
        {
            if (characters.Count == 0)
            {
                Console.WriteLine("\nNo characters found.");
                return;
            }
            foreach (Character c in characters)
            {
                c.DisplayDetails();
            }
        }
        static void SearchRecords(List<Character>characters)
        {
            Console.Write("\nEnter Character name to search: ");
            string searchName = Console.ReadLine();
            bool found = false;
            foreach (Character c in characters)
            {
                if (c.Name.ToLower() == searchName.ToLower())
                {
                    c.DisplayDetails();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("\nNo Character found.");
            }
        }
        static void DisplaySummary(List<Character> characters)
        {
            if (characters.Count == 0)
            {
                Console.WriteLine("\nNo Summary records.");
                return;
            }
            int totalLevels = 0;
            int highestStrength = 0;
            foreach (Character c in characters)
            {
                totalLevels += c.Level;
                if (c.Strength > highestStrength)
                {
                    highestStrength = c.Strength;
                }
            }
            double averageLevel = (double)totalLevels / characters.Count;
            Console.WriteLine("\nSummary Statistics");
            Console.WriteLine($"Total Characters: {characters.Count} ");
            Console.WriteLine($"Average Level: {averageLevel}");
            Console.WriteLine($"Highest Strength: {highestStrength}");

        } 
        static int ReadInt(string message)
        {
            int value;
            bool valid = false;
            while (!valid)
            {
                Console.Write(message);
                string input = Console.ReadLine();
                try
                {
                    value = int.Parse(input);
                    return value;
                }
                catch
                {
                    Console.WriteLine("Invalid Number, Please TRY AGAIN");
                }
            }
            return 0;
        }
        static bool ReadBool(string message)
        {
            while (true)
            {
                Console.Write(message);
                string input = Console.ReadLine().ToLower();
                if (input == "true")
                    return true;
                if (input == "false")
                    return false;
                Console.WriteLine("Invalid input. Enter true or false");
            }
        }
    }
}
