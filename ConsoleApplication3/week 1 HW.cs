using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean calculated = false;
            while (!calculated)
            {
                Console.WriteLine("Hi there, When where you born?");
                Console.WriteLine("dd-mm-yyyy");
                String input = Console.ReadLine();

                String[] date = input.Split('-');
                if (date.Length == 3)
                {
                    if (date[0].Length == 2 || date[1].Length == 2 || date[2].Length == 4)
                    {
                        if (date[0].All(char.IsDigit) && date[1].All(char.IsDigit) && date[2].All(char.IsDigit))
                        {
                            if (Int32.Parse(date[0]) < 32 && Int32.Parse(date[0]) > 0)
                            {
                                if (Int32.Parse(date[1]) < 13 && Int32.Parse(date[1]) > 0)
                                {
                                    if (Int32.Parse(date[2]) > 1900 && Int32.Parse(date[2]) < DateTime.Today.Year)
                                    {
                                        if (Int32.Parse(date[1]) < DateTime.Today.Month || (Int32.Parse(date[1]) == DateTime.Today.Month && Int32.Parse(date[0]) <= DateTime.Today.Day))
                                        {
                                            Console.WriteLine("You are " + (DateTime.Today.Year - Int32.Parse(date[2])));
                                            Console.Read();
                                            calculated = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("You are " +( DateTime.Today.Year - Int32.Parse(date[2]) - 1));
                                            Console.Read();
                                            calculated = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                if (!calculated)
                {
                    Console.WriteLine("Wrong input format");
                }
            }
        }
    }
}
