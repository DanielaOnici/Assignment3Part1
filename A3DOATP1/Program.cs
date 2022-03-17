using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3DOATP1
{
    class Program
    {
        static double MultiplyEven (double a)
        {
            return (a * 7);
        }

        static double MultiplyOdd (double a)
        {
            return (a * 8);
        }

        static double Division (double a)
        {
            return (a / 3);
        }

        static void Main(string[] args)
        {
            double NumberChosen, i, Result;
            string Answer, Answer1;

                do
                {
                    Console.WriteLine("Choose one of the options below\nOption 1: list of 20 numbers and calculation\nOption 2: divides the number by 3\nOption 3: End");
                    Answer = Console.ReadLine();

                    if (Answer == "1")
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Input a number ");
                                Answer1 = Console.ReadLine();
                                NumberChosen = double.Parse(Answer1);

                                Console.WriteLine("The list of 20 numbers and their products is ");

                                for (i = NumberChosen; i < (NumberChosen + 20); i++)
                                {
                                    Console.WriteLine(i);

                                    if (i % 2 == 0)
                                    {
                                        Result = MultiplyEven(i);
                                        Console.WriteLine("The product of the even number by 7 is {0}", Result);
                                    }
                                    else
                                    {
                                        Result = MultiplyOdd(i);
                                        Console.WriteLine("The product of the odd number by 8 is {0}", Result);
                                    }

                                }
                                break;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Input only numbers");
                            }
                        }

                    }
                    else if (Answer == "2")
                    {
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("Input a number or END to return to the main menu");
                                Answer1 = Console.ReadLine();

                                if (Answer1 == "END")
                                {
                                    break;
                                }
                                else
                                {
                                    NumberChosen = double.Parse(Answer1);
                                    Result = Division(NumberChosen);
                                    Console.WriteLine("The result is {0}", Result);
                                }

                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine(e.Message);
                            }

                        }
                    }

                    else if (Answer == "3")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not one of the options. Insert just the number of the option");
                    }

                } while (true);
            

        }
    }
}
