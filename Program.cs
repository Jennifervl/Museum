using System;

namespace Museum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO TOBACCO AND SALT MUSEUM!");
            string currentRoom = "entrance";
            string choice="";
            Random random = new Random();
            int chance =0;
            bool fire= false;
            int roomsVisited = 0;
            bool room = true;
            while(true)
            {
                if (fire ==false)
                {
                
                    chance = random.Next(1,11);
                    if (chance == 1)
                    {
                        fire = true;
                    }
                }
                if (fire==true && currentRoom != "exit" )
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("A fire has started! Navigate to the exit.");
                        Console.ResetColor();
                        if (room==true)
                        {
                        roomsVisited++;
                        }
                        else
                        {
                            room = true;
                        }
                    }

                if (currentRoom == "entrance")
                {                
                    Console.WriteLine("You are in the beautiful entrance, what would you like to do?");
                    Console.WriteLine("Go north to Exhibition hall 1: [1]");
                    Console.WriteLine("Go west to Exhibition hall 2: [2]");
                    Console.WriteLine("Go to café: [3]");
                    Console.WriteLine("Go to WC: [4]");
                    Console.WriteLine("Go home: [5]");
                    Console.WriteLine("Look at salt sculptures: [6]");
                    Console.WriteLine("Look at cigars: [7]");

                    choice = Console.ReadLine();
                    
                    if (choice == "1")
                    {
                        currentRoom = "exhibitionHall1";
                    }
                    else if(choice=="2")
                    {
                        currentRoom = "exhibitionHall2";
                    }
                    else if(choice=="3")
                    {
                        currentRoom = "café";
                    }
                    else if(choice=="4")
                    {
                        currentRoom = "wc";
                    }
                    else if(choice=="5")
                    {
                        currentRoom = "exit";
                    }
                    else if(choice=="6")
                    {
                        Console.WriteLine("Information about salt sculptures.");
                        Console.ReadLine();
                        room = false;
                    }
                    else if(choice=="7")
                    {
                        Console.WriteLine("Information about cigars");
                        Console.ReadLine();
                        room = false;
                    }
                }
                else if(currentRoom == "exhibitionHall1")
                {
                    Console.WriteLine("You are in Exhibition hall 1. What would you like to do?");
                    Console.WriteLine("Go back to entrance: [1]");
                    Console.WriteLine("Go to café: [2]");
                    Console.WriteLine("Go to Exhibition 2: [3]");
                    Console.WriteLine("Information about Saultwater evaporate. [4]");

                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        currentRoom = "entrance";

                    }
                    else if (choice == "2")
                    {
                        currentRoom = "café";
                    }
                    else if (choice == "3")
                    {
                        currentRoom = "exhibitionHall2";
                    }
                    else if (choice == "4")
                    {
                        Console.WriteLine("Information about Saltwater evaporate.");
                        Console.ReadLine();
                        room = false;
                    }
                }
                else if(currentRoom=="café")
                {
                    Console.WriteLine("You are in Café. What would you like to do?");
                    Console.WriteLine("Go to Gift Shop. [1]");
                    Console.WriteLine("Go to Exhibition 1. [2]");
                    Console.WriteLine("Go to entrance. [3]");

                    choice = Console.ReadLine();

                    if (choice =="1")
                    {
                        currentRoom = "giftShop";
                    }
                    else if (choice =="2")
                    {
                        currentRoom = "exhibitionHall1";
                    }
                    else if (choice =="3")
                    {
                        currentRoom = "entrance";
                    }

                }
                else if(currentRoom=="exhibitionHall2")
                {
                    Console.WriteLine("You are in exhibition hall 2. What would you like to do?");
                    Console.WriteLine("Go back to entrance. [1]");
                    Console.WriteLine("Look at pipes. [2]");
                    Console.WriteLine("Look at pictures of himalaya. [3]");

                    choice = Console.ReadLine();
                    if (choice =="1")
                    {
                        currentRoom = "entrance";
                    }
                    else if(choice=="2")
                    {
                        Console.WriteLine("Information about pipes.");
                        Console.ReadLine();
                    }
                    else if(choice=="3")
                    {
                        Console.WriteLine("Pictures of himalaya");
                        Console.ReadLine();
                        room = false;
                    }
                }
                else if(currentRoom=="wc")
                {
                    Console.WriteLine("You are in WC. Do you want to exit?");
                    Console.WriteLine("Go back to entrance. [1]");

                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        currentRoom = "entrance";
                    }
                }
                else if(currentRoom=="giftShop")
                {
                    Console.WriteLine("you are in Gift Shop. ");
                    Console.WriteLine("Go back to café: [1]");

                    choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        currentRoom = "café";
                    }
                }
                else if(currentRoom=="exit")
                {
                    Console.WriteLine("You visited " + roomsVisited + " rooms after the fire started.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
