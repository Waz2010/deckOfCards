using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;

public class Program
{

    public delegate int myDelegate(int num1, int uum2);
    public delegate int myDelegateeven(int[] arr);
    public static int jj = 0;
    public static int evennumb(int[] myarr)
    {
            return myarr.Where(i => i % 2 == 0).Sum(i => i);
    }

    public static int calculatesum(int x, int y)
    {
        return x + y;
    }
    public static DateTime time;
    public static void Main()
    {
        string s1 = "like for example $  you don't have $  network $  access";
        Console.WriteLine("before: {0}", s1);

        GroupCollection halves = Regex.Match(s1, @"([^$]*\$)(.*)").Groups;
        string answer = halves[1].Value + halves[2].Value.Replace("$", "");

        Console.WriteLine("after: {0}", answer);

        string[] Names = { "Sheraz Haider", "waseem aider", "waqar ider", "shehzad der " };
        var FindWaseem = from namee in Names where !namee.EndsWith("JO") select namee;
        int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1, 10 };
        myDelegateeven d1 = new myDelegateeven(evennumb);

        int ressss = d1(ar);
        /* ... */
        if (time == null)
        {
            Console.WriteLine("Time is null");
        }

        //StringBuilder sb = new StringBuilder("Testthis")














        // "20" is capacity 
        StringBuilder s = new StringBuilder("HELLO ", 3);

        s.Append("GFG");

        // after printing "GEEKS" 
        // a new line append 
        s.AppendLine("GEEKS");

        s.Append("GeeksForGeeks");
        Console.WriteLine(s);

        myDelegate d = new myDelegate(calculatesum);

        var res = d(5, 6);

        Console.WriteLine(res);

        int TotalCoffeeCost = 0;
        NewOrder:
        Console.WriteLine("Please Enter 1 - for Small, 2 - for Medium, 3 - for Large...");
        int CoffeeCupSize = int.Parse(Console.ReadLine());

        switch (CoffeeCupSize)
        {
            case 1: TotalCoffeeCost += 1; break;
            case 2: TotalCoffeeCost += 2; break;
            case 3: TotalCoffeeCost += 3; break;
            default:          
                Console.WriteLine("Your Choice is invalid.. Please 1 - for Small, 2 - for Medium, 3 - for Large... ");goto NewOrder;
        }

        DecideAnotherCup:
        Console.WriteLine("You want another cup of coffee.. Yes or NO?");
        string AnotherCupofCoffee = Console.ReadLine().ToUpper();

        do {
            if (AnotherCupofCoffee != "YES" && AnotherCupofCoffee != "NO")
            {
                Console.WriteLine("Your choice {0} is invalid. Please try again...", AnotherCupofCoffee);
                goto DecideAnotherCup;
            }
            else if (AnotherCupofCoffee.Equals("NO"))
            {
                goto Billing;
            }
            else 
            {
                goto NewOrder;
            }
                
        } while (AnotherCupofCoffee.Equals("YES"));

        //switch (AnotherCupofCoffee.ToUpper());
        //{
        //    case "YES":goto NewOrder;
        //    case "NO": goto Billing;
        //    default: Console.WriteLine("Your choice {0} is invalid. Please try again...", AnotherCupofCoffee);
        //        goto DecideAnotherCup; 
        //}

        Billing:
        Console.WriteLine("Thank you for shopping with us!");
        Console.WriteLine("Bill amount is = {0}", TotalCoffeeCost);




        //do
        //{
        //    Console.WriteLine("Enter number... 1 , 2 or 3");
        //    int Mynumber = int.Parse(Console.ReadLine());

        //}while(Mynumber == 3)


        Class2 C1 = new Class2("Waseem","Haider",null);

       





        Console.ReadLine();

    }

}


/// <summary>
/// This is to understand null collasing
/// </summary>
public class Class2
{
    string _FName;
    string _LName;
    int? _NumberOfStudent;

    /// <summary>
    /// This is to understand null collasing 
    /// </summary>
    /// <param name="FName"  takes int ></param>
    /// <param name="LName" takes int ></param>
    /// <param name="NumberOfStudent" takes int ></param>
    public Class2(string FName, string LName, int? NumberOfStudent)
    {
        _FName = FName;
        _LName = LName;
        _NumberOfStudent = NumberOfStudent;
        _NumberOfStudent = _NumberOfStudent ?? 0;
        Console.WriteLine(_FName + ":" + _LName + " : " + _NumberOfStudent);
    }

}

