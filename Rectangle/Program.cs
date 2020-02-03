using System;
using System.Collections.Generic;
using System.Text;
namespace Rectangle
{
    class Program : Rectangle
    {
        static void Main(string[] args)
        {


            Rectangle a = new Program();
            int len;
            int wid;
            Console.WriteLine("Welcome \n");
            Console.WriteLine("1. Please enter Length of rectangle");
            Console.WriteLine("2. Please enter Width of rectangle\n");
            bool again = true;
            while (again)
            {
                try
                {
                    do
                    {
                        len = int.Parse(Console.ReadLine());
                        
                        if (len <= 0)
                        {
                            Console.WriteLine(" Please enter valid value ( more than zero) please enter again \n");
                            Console.ReadLine();
                        }
                        else
                        {
                            a.SetLength(len);
                        }
                    }

                    while (len < 0);

                    do
                    {
                        wid = int.Parse(Console.ReadLine());

                        if (wid <= 0)
                        {
                            Console.WriteLine(" Please enter valid value ( more than zero) please enter again \n");
                            Console.ReadLine();
                        }else
                        {
                            a.SetWidth(wid);
                        }
                    }while (wid < 0);
                    again = false;


                }
                catch (Exception)
                {

                    Console.WriteLine("The input is wrong please enter both integer value again \n");


                };
            }



            bool repeat = true;
            while (repeat)
            {
                try
                {
                    Console.WriteLine("\nWelcome to Menu");
                    Console.WriteLine("Select anyone option from below ?");
                    Console.WriteLine("1. Get Rectangle Length.");
                    Console.WriteLine("2. Change Rectangle Length.");
                    Console.WriteLine("3. Get Rectangle Width.");
                    Console.WriteLine("4. Change Rectangle Width.");
                    Console.WriteLine("5. Get Rectangle Perimeter.");
                    Console.WriteLine("6. Get Rectangle Area.");
                    Console.WriteLine("7. Exit\n");
                    int userInput = int.Parse(Console.ReadLine());


                    switch (userInput)
                    {
                        case 1:

                            Console.WriteLine("\n Value is : "+ a.GetLength());

                            break;
                        case 2:
                            //int length;

                            Console.WriteLine("\n Please enter Length of rectangle:");

                            a.SetLength(int.Parse(Console.ReadLine()));


                            break;

                        case 3:


                            Console.WriteLine("\n Value is : " + a.GetWidth());

                            break;
                        case 4:

                            Console.WriteLine("\n Please enter width of rectangle:");
                            a.SetWidth(int.Parse(Console.ReadLine()));

                            break;
                        case 5:

                            Console.WriteLine(a.GetPerimeter());

                            break;
                        case 6:

                            Console.WriteLine(a.GetArea());

                            break;
                        case 7:

                            Console.WriteLine("Thank you.\n");
                            System.Environment.Exit(0);
                            repeat = false;
                            break;

                        default:
                            Console.WriteLine("Wrong input !!  please enter 1-7 only \n ");

                            continue;



                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("The input is wrong please enter value again ");


                };



            }
        }
    }
}
