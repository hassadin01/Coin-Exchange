using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            int cash = 0; int quan = 0;
            int one = 100; int five = 100; int ten = 100;
            int coin_one = 0; int coin_five = 0; int coin_ten = 0;
            int change = 0;
            int totalcash = 0; int totalbuc = 0;
            bool Conditioncash = true;
            bool Conditionend = true;

            Console.WriteLine("Console Coin Exchange in C#\r");
            Console.WriteLine("----------------------------\n");
            while(Conditionend) 
            { 
                while (Conditioncash)
                {
                    //while (Conditioncash)
                    //{
                        Console.WriteLine("Choose an option from the following list:");
                        Console.WriteLine("\t20 - 20 bath");
                        Console.WriteLine("\t50 - 50 bath");
                        Console.WriteLine("\t100 - 100 bath");
                        Console.Write("Your cash? ");
                        switch (Console.ReadLine())
                        {
                            case "20":
                                cash = 20;
                                break;
                            case "50":
                                cash = 50;
                                break;
                            case "100":
                                cash = 100;
                                break;
                            default:
                                Console.WriteLine("Please input your cash agian.\n\n");
                                cash = 0;
                                continue;
                        }
                    //}
                    Console.WriteLine("Type a quantity of your cash");
                    quan = Convert.ToInt32(Console.ReadLine());
                    totalcash += cash * quan;
                    totalbuc = one + (five*5) + (ten*10);
                    if (totalcash>totalbuc) 
                    {
                        Console.WriteLine($"Your cash {totalcash} and my coin {totalbuc} it too much  \n");
                        cash = 0;
                        quan = 0;
                        totalcash = 0;
                        continue;
                    }
                    Console.WriteLine($"Your Total cash: {totalcash}\n");
                    Console.WriteLine("Do you want to add your cash more?: ");
                    Console.WriteLine("\ty - Yes");
                    Console.WriteLine("\tn - No");
                    switch (Console.ReadLine())
                    {
                        case "y":
                            cash = 0;
                            quan = 0;
                            Console.Clear();
                            continue;


                        case "n":
                            Conditioncash = false;
                            break;
                    }  
                }
           
                coin_ten = totalcash / 10;
                if (ten < coin_ten)
                {
                    coin_ten = ten;
                    change = totalcash - (ten * 10);
                    coin_five = change / 5;
                }
                else
                {
                    change = totalcash % 10;
                    coin_five = change / 5;
                }
                if (five < coin_five)
                {
                    coin_five = five;
                    coin_one = change - (five * 5);

                }
                else
                {
                    change = change % 5;
                    coin_one = change;
                }
                Console.WriteLine($"Your Total coin 10 : {coin_ten}\n");
                Console.WriteLine($"Your Total coin  5 : {coin_five}\n");
                Console.WriteLine($"Your Total coin  1 : {coin_one}\n");

                Console.WriteLine("Are you sure to exchange ?: ");
                Console.WriteLine("\ty - Yes");
                Console.WriteLine("\tn - No");
                switch (Console.ReadLine())
                {
                    case "y":
                        ten = ten-coin_ten;
                        five = five-coin_five;
                        one = one - coin_one;
                        Console.WriteLine($"My Total coin 10 : {ten}\n");
                        Console.WriteLine($"My Total coin  5 : {five}\n");
                        Console.WriteLine($"My Total coin  1 : {one}\n");
                        break;

                    case "n":
                        
                        break;
                }
                Console.WriteLine("Do you want exchange again ?: ");
                Console.WriteLine("\ty - Yes");
                Console.WriteLine("\tn - No");
                switch (Console.ReadLine())
                {
                    case "y":
                        totalcash = 0;
                        Conditioncash = true;
                        Console.Clear();
                        break;

                    case "n":
                        Conditionend = false;
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
