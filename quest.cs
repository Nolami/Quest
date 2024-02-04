using System;


class Program
{
    static void val()
    {
        while (true)
        {
        Console.WriteLine("When is our anniversary? ");
        Console.WriteLine();
        Console.Write("Insert the day here: ");
        int date = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Insert the month here (as a word): ");
        string month = Console.ReadLine();
        Console.WriteLine();
        
        if (date == 19 && month.ToLower() == "september")
        {
            Console.WriteLine("Good job, Dear");
            Console.WriteLine();
                break;
        }
        else
        {
            Console.WriteLine("You guessed wrong");
            Console.WriteLine();
        }

        }
    }

    static void valr()
    {
        while (true)
        {
            Console.WriteLine("When is my birthday? ");
            Console.WriteLine();
            
            Console.Write("Insert the day here: ");
            int date = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            Console.Write("Insert the month here: ");
            string month = Console.ReadLine();
            Console.WriteLine();

            if (date == 4 && month.ToLower() == "december")
            {
                Console.WriteLine("Good job, Dear, I'm proud of you");
                Console.WriteLine();
                break;
            }
            else
            {
                Console.WriteLine("It's fine dear, try again");
                Console.WriteLine();
            }
        }
    }
    
    static void gues()
    {
        Console.WriteLine("Will you be my valentine? ");
        Console.WriteLine();
        Console.Write("Yes or No: ");
        string que = Console.ReadLine();
        Console.WriteLine();
        
        if (que.ToLower() == "yes")
        {
            Console.WriteLine("Yippee.");
        }
        else
        {
            Console.WriteLine("Awh :(");
        }
    }

    static void Main(string[] args)
    {

        val();
        valr();
        gues();
    }
}
