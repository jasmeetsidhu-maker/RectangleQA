using System;

namespace Rectangle
{
    class Program : Rectangle
    {
        static void Main(string[] args)
        {

            // variable declare
            Rectangle a = new Program();
            int len;
            int wid;
            // Repeat condition if wrong input
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

                    //  All Seven Options for user 
                    switch (userInput)
                    {

                        // get default value and update value
                        case 1:

                            Console.WriteLine("\n Value is : " + a.GetLength());

                            break;


                        case 2:
                            //change length value 

                            bool again = true;
                            while (again)
                            {
                                try
                                {
                                    do
                                    {
                                        Console.WriteLine("1. Please enter Length of rectangle");
                                        len = int.Parse(Console.ReadLine());

                                        if (len <= 0)
                                        {
                                            Console.WriteLine(" Please enter valid value ( more than zero) please enter again \n");
                                            
                                        }
                                        else
                                        {
                                            a.SetLength(len);
                                        }
                                        


                                    } while (len <= 0);
                                    again = false;
                                }
                                catch (Exception)
                                {

                                    Console.WriteLine("The input is wrong please enter both integer value again \n");


                                }

                            }

                                break;
                            

                        case 3:
                            // get default value and update value

                            Console.WriteLine("\n Value is : " + a.GetWidth());

                            break;

                        case 4:
                            //change width value 

                            bool again1 = true;
                            while (again1)
                            {
                                try
                                {
                                    do
                                    {
                                        Console.WriteLine("2. Please enter Width of rectangle\n");
                                        wid = int.Parse(Console.ReadLine());

                                        if (wid <= 0)
                                        {
                                            Console.WriteLine(" Please enter valid value ( more than zero) please enter again \n");
                                            
                                        }
                                        else
                                        {
                                            a.SetWidth(wid);
                                        }
                                        
                                    } while (wid <= 0);
                                    again1 = false;
                                }
                                catch (Exception)
                                {

                                    Console.WriteLine("The input is wrong please enter both integer value again \n");


                                }
                            }
                                break;
                        case 5:

                            // Get Perimeter

                            Console.WriteLine(a.GetPerimeter());

                            break;
                        case 6:
                            // Get area result 
                            Console.WriteLine(a.GetArea());

                            break;
                        case 7:
                            //exit menu
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
