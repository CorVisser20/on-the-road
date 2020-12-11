using System;
using System.Threading;
using System.Collections.Generic;

namespace OnTheRoad
{
    // Class Game //
    class Game
    {

        // Inventory List //
        static List<string> Inventory = new List<string>();

        // Function Intro //
        public static void Intro()
        {

            Functions.Print("Welcome to ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Functions.Print("On The Road");
            Functions.ResetColor();
            Functions.Print(".\n\n");

            // Console Sleep //
            System.Threading.Thread.Sleep(2000);

            Functions.Print("In this game you can make your own choices. You have two options: A or B. \n" +
                "Depending on the choice you make, something happens. One tip: think realistic. \n" +
                "What would you do in this situation?\n\n", 10);

            // Console Sleep //
            System.Threading.Thread.Sleep(1000);

            Functions.Print("Let's start with an example!\n\n");

            // Console Sleep //
            System.Threading.Thread.Sleep(1000);

            Functions.Print("Would you like to start the game?\n");
            Functions.Print("[A] Start the game! [B] Quit\n\n");

            // Create A Variable For Input //
            string input = "";
            input = Console.ReadLine();
            input = input.ToUpper();

            if (input == "A")
            {

                // Move One Line Up //
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Console.ForegroundColor = ConsoleColor.Green;
                Functions.Print("Starting game...", 80);

                // Reset Color //
                Functions.ResetColor();

                // Console Sleep //
                System.Threading.Thread.Sleep(1000);

                // Clear Console //
                Console.Clear();

                // Call EnterName //
                Game.EnterName();

            } else if (input == "B")
            {

                // Move One Line Up //
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Console.ForegroundColor = ConsoleColor.Red;
                Functions.Print("Quiting game...\n\n", 80);

                // Console Sleep //
                System.Threading.Thread.Sleep(2000);

                Environment.Exit(0);

                // Reset Color //
                Functions.ResetColor();

            } else
            {

                // Clear Console //
                Console.Clear();
                Console.WriteLine("You didn't type in A or B. Try again.");

                Game.Intro();

            }

        }

        // Function EnterName //
        public static void EnterName()
        {

            // Console Sleep //
            System.Threading.Thread.Sleep(1000);

            Functions.Print("What should your character name be?\n\n");

            Console.ForegroundColor = ConsoleColor.Yellow;

            // Create A Variable For Input //
            String CharacterName = Console.ReadLine();

            // Reset Color //
            Functions.ResetColor();

            // Console Sleep //
            System.Threading.Thread.Sleep(1000);

            // Clear Console //
            Console.Clear();

            // Call StartGame //
            Game.StartGame();

        }

        // Function StartGame //
        public static void StartGame()
        {

            // Console Sleep //
            System.Threading.Thread.Sleep(2000);

            Functions.Print("It's already late and freezing, you're done with work and wants to go home. " +
               "You get in your car and leave the parking\narea. You're driving on " +
                "a long, dark road. You're tired after a long day of work. " +
                "Suddenly the phone rings, your wife\nis calling. " +
                "After talking for a while, you are startled by a crossing animal. " +
                "You suddenly steer to the right\nto avoid collision with the animal. " +
                "Trees are coming closer and closer. Before you can even realize\nwhat's " +
                "happening, you crash into a tree.", 10);

            // Console Sleep //
            System.Threading.Thread.Sleep(2000);

            Functions.Print("\n\nYou're waking up... dizzy, cold and trying to remember what happend.\n" +
                "You feel an incredibly pain on your forehead. You realizing that you've been crashed. \n" +
                "When you look around you see that your mobile phone is not working anymore.", 10);

            // Console Sleep //
            System.Threading.Thread.Sleep(1000);

            // Clear Console //
            Console.Clear();

            Functions.Print("When you get out of your car to take a look, you see that your car is broken. \n" +
                "You're in the middle of nowhere, alone and it's cold...\n\n" +
                "You take a look in the glove box. You've found an old flashlight.\n", 10);

            // Add Flashligt To Inventory //
            Inventory.Add("Flashlight");

            Console.ForegroundColor = ConsoleColor.Green;
            Functions.Print("Added flashlight to your inventory.");

            // Reset Color //
            Functions.ResetColor();

            // Console Sleep //
            System.Threading.Thread.Sleep(1000);

            // Clear Console //
            Console.Clear();

            Functions.Print("You starting to run through the woods when you see a small river. \n");

            Game.Choice1();

        }

        // Choice 1 //
        public static void Choice1()

        {         // Console Sleep //
            System.Threading.Thread.Sleep(1000);

            Functions.Print("Would you cross the river or walk around it?\n\n");
            Functions.Print("[A] Cross the river [B] Walk around the river\n\n");

            // Create A Variable For Input //
            string input = "";
            input = Console.ReadLine();
            input = input.ToUpper();

            if (input == "A")
            {

                // Move One Line Up //
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Functions.Print("You slowly walking in the river, it's freezing cold. \n" +
                    "You're trying to swim but you get cramps from the cold. You're drowning.");

                // Console Sleep //
                System.Threading.Thread.Sleep(1000);

                // Clear Console //
                Console.Clear();

                Game.GameOver();

            }
            else if (input == "B")
            {

                // Move One Line Up //
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Functions.Print("After a long walk you see a bridge. You cross the bridge. \n" +
                    "After a while you see some headlights in the distance. You start signing with \n" +
                    "your flashlight. Unfortunately the car enters a side road. He hasn't noticed you.\n\n");

                // Console Sleep //
                System.Threading.Thread.Sleep(1000);

                Functions.Print("You've been walking for a hour not seeing anyone or anything. You're tired and cold.\n\n");

                // Console Sleep //
                System.Threading.Thread.Sleep(1000);

                Functions.Print("Would you take a rest under a tree or walk further?\n\n");
                Functions.Print("[A] Take a rest [B] Walk further\n\n");

                Game.Choice2();

            }
            else
            {

                // Clear Console //
                Console.Clear();
                Console.WriteLine("You didn't type in A or B. Try again.");

                Game.Choice1();

            }
        }

        // Choice 2 //
        public static void Choice2()
        {
            // Create A Variable For Input //
            string input = "";
            input = Console.ReadLine();
            input = input.ToUpper();

            if (input == "A")
            {

                // Move One Line Up //
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Functions.Print("You decide to take a rest. You sit against a tree and fall asleep. \n" +
                    "Because of the cold, you've been freezing to death.");

                // Console Sleep //
                System.Threading.Thread.Sleep(1000);

                // Clear Console //
                Console.Clear();

                Game.GameOver();

            }
            else if (input == "B")
            {

                // Move One Line Up //
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Functions.Print("You decided to walk futher, no mather how cold and tired you are. You have to move on. \n");

                // Console Sleep //
                System.Threading.Thread.Sleep(1000);

                Functions.Print("You look around and see a house. As you come closer to the house you notice \n" +
                    "that it's an abandoned, wooden house. After a short walk you're entering the house. The door was broken. \n" +
                    "You're searching for anything that might be usefull. You find some matches. \n\n");

                // Add Flashligt To Inventory //
                Inventory.Add("Matches");

                Console.ForegroundColor = ConsoleColor.Green;
                Functions.Print("Added matches to your inventory.");

                // Console Sleep //
                System.Threading.Thread.Sleep(2000);

                // Clear Console //
                Console.Clear();

                // Reset Color //
                Functions.ResetColor();

                Functions.Print("When you walk into the livingroom you see a fireplace.\n\n");

                // Console Sleep //
                System.Threading.Thread.Sleep(1000);

                Functions.Print("Would you go outside and create your own fireplace, or would you \n" +
                    "make a fire inside of the house?\n\n");
                Functions.Print("[A] Make a fire outside [B] Make a fire in the house\n\n");

                Game.Choice3();

            }
            else
            {

                // Clear Console //
                Console.Clear();
                Console.WriteLine("You didn't type in A or B. Try again.");

                Game.Choice2();

            }
        }

        // Choice 3 //
        public static void Choice3()
        {
            // Create A Variable For Input //
            string input = "";
            input = Console.ReadLine();
            input = input.ToUpper();

            if (input == "A")
            {

                // Move One Line Up //
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Functions.Print("You're taking the matches with you and go outside. When you walk around the house \n" +
                    "to find a good spot you see a carport. You decide to collect some branches en make a fire close to the \n" +
                    "carport. You can sit out of the wind and stay warm. You fall asleep... \n\n" +
                    "Suddenly you wake up, you hear a car coming closer. When you open your eyes your noticing it's a police car. \n" +
                    "You start signing with your flashlight again. The police car is coming your way. \n\n" +
                    "When the police officer gets out of his car he's asking you what's happening. You answer that you've been \n" +
                    "crashed with your car. The police officer calls his colleagues over the radio and tell them that a car \n" +
                    "has been crashed on Lakeview and he talks to the owner.\n\n" +
                    "The police officer asks you if he can bring you home. You're so happy that anyone found you.");

                // Console Sleep //
                System.Threading.Thread.Sleep(1000);

                // Clear Console //
                Console.Clear();

                Game.EndGame();

            }
            else if (input == "B")
            {

                // Move One Line Up //
                Console.SetCursorPosition(0, Console.CursorTop - 1);

                Functions.Print("You collect some branches from outside to make a fire in the house. \n" +
                    "It becomes warmer, exactly what you needed after this adventure. You're tired and \n" +
                    "decide to take a rest. After a while, you're waking up because of the heat. When you \n" +
                    "open your eyes, your noticing that the whole room is in fire. You die in the fire.");

                // Console Sleep //
                System.Threading.Thread.Sleep(1000);

                // Clear Console //
                Console.Clear();

                Game.GameOver();

            }
            else
            {

                // Clear Console //
                Console.Clear();
                Console.WriteLine("You didn't type in A or B. Try again.");

                Game.Choice3();

            }
        }

        // Function GameOver //
        public static void GameOver()
        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.Title = "ASCII Art";
            string Title = @"


              _______      ___      .___  ___.  _______      ______   ____    ____  _______ .______      
             /  _____|    /   \     |   \/   | |   ____|    /  __  \  \   \  /   / |   ____||   _  \     
            |  |  __     /  ^  \    |  \  /  | |  |__      |  |  |  |  \   \/   /  |  |__   |  |_)  |    
            |  | |_ |   /  /_\  \   |  |\/|  | |   __|     |  |  |  |   \      /   |   __|  |      /     
            |  |__| |  /  _____  \  |  |  |  | |  |____    |  `--'  |    \    /    |  |____ |  |\  \----.
             \______| /__/     \__\ |__|  |__| |_______|    \______/      \__/     |_______|| _| `._____|
                                                                                             

            ";
            Console.WriteLine(Title);

            Functions.Print("Quiting game...\n", 80);

            // Console Sleep //
            System.Threading.Thread.Sleep(4000);
            Environment.Exit(0);

            // Reset Color //
            Functions.ResetColor();

        }


        // Function EndGame //
        public static void EndGame()
        {

            Console.ForegroundColor = ConsoleColor.Green;

            Console.Title = "ASCII Art";
            string Title = @"


             _______ .__   __.  _______       _______      ___      .___  ___.  _______ 
            |   ____||  \ |  | |       \     /  _____|    /   \     |   \/   | |   ____|
            |  |__   |   \|  | |  .--.  |   |  |  __     /  ^  \    |  \  /  | |  |__   
            |   __|  |  . `  | |  |  |  |   |  | |_ |   /  /_\  \   |  |\/|  | |   __|  
            |  |____ |  |\   | |  '--'  |   |  |__| |  /  _____  \  |  |  |  | |  |____ 
            |_______||__| \__| |_______/     \______| /__/     \__\ |__|  |__| |_______|
                                                                            


            ";
            Console.WriteLine(Title);

            Functions.Print("\nCongratulations! You've finished the game. Here are the items you've collected:\n\n", 80);
            foreach (string item in Inventory)
            {
                Functions.Print(item + "\n");
            }

            // Console Sleep //
            System.Threading.Thread.Sleep(4000);
            Environment.Exit(0);

        }

    }

    // Class Program //
    class Program
    {
        
        // Function Main //
        public static void Main()
        {

            // Call Intro //
            Game.Intro();

            // Read Key //
            Console.ReadKey();

        }

    }

    // Class Functions //
    class Functions
    {

        // Function ResetColor //
        public static void ResetColor()
        {

            Console.ForegroundColor = ConsoleColor.Gray;

        }

        // Function Print Text //
        public static void Print(string text, int speed = 40)
        {

            foreach (char c in text)
            {

                Console.Write(c);
                System.Threading.Thread.Sleep(speed);

            }

        }

    }
}
