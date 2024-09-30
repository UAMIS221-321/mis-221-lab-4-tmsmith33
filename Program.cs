using System;

class CrimsonCrust
{
    static Random random = new Random();
    
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Welcome to Crimson Crust! Please select an option:");
            Console.WriteLine("1. Plain Pizza Slice");
            Console.WriteLine("2. Cheese Pizza Slice");
            Console.WriteLine("3. Pepperoni Pizza Slice");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    PlainPizza();
                    break;
                case "2":
                    CheesePizza();
                    break;
                case "3":
                    PepPizza();
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Exiting the menu. Thank you!");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please enter 1, 2, 3, or 4.");
                    break;
            }
        }
    }

    // Method to display the plain pizza slice
    static void PlainPizza()
    {
        int rows = random.Next(8, 13); 
        for (int i = rows; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    // Method to display the cheese pizza slice
    static void CheesePizza()
    {
        int rows = random.Next(8, 13); 
        for (int i = rows; i > 0; i--)
        {
            if (i == rows)
            {
                Console.WriteLine(new string('*', rows));
            }
            else
            {
                Console.Write("*");
                Console.Write(new string('#', i - 1));
                Console.WriteLine("*");
            }
        }
    }

    // Method to display the pepperoni pizza slice
    static void PepPizza()
    {
        int rows = random.Next(8, 13); 
        for (int i = rows; i > 0; i--)
        {
            if (i == rows)
            {
                Console.WriteLine(new string('*', rows));
            }
            else
            {
                Console.Write("*");
                char[] row = new char[i - 1];
                for (int j = 0; j < i - 1; j++)
                {
                    if (random.Next(2) == 0 && i > 2) // Randomly place a pepperoni ('[]') but not on very small slices
                    {
                        row[j] = '[';
                        if (j + 1 < i - 1) row[j + 1] = ']'; // Ensure [] are together
                        j++;
                    }
                    else
                    {
                        row[j] = '#';
                    }
                }
                Console.Write(row);
                Console.WriteLine("*");
            }
        }
    }
}
