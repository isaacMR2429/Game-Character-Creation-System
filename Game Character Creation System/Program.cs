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
                Console.WriteLine("4. Display Character");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                
            }
        }
    }
}
