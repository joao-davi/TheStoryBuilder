using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace TellingStories
{
    class Game
    {
        public void Start()
        {
            Console.Title = "The Story Builder";
            
            RunMainMenu();
        }

        private void RunMainMenu()
        {

            string[] options = { "BUILD", "Documentation", "Demo", "Exit" };
            string prompt = @"

 _       ____  _     __    ___   _      ____     _____  ___  
\ \    /| |_  | |   / /`  / / \ | |\/| | |_       | |  / / \ 
 \_\/\/ |_|__ |_|__ \_\_, \_\_/ |_|  | |_|__      |_|  \_\_/ 
  ________            _____ __                      ____        _ __    __         
 /_  __/ /_  ___     / ___// /_____  _______  __   / __ )__  __(_) /___/ /__  _____
  / / / __ \/ _ \    \__ \/ __/ __ \/ ___/ / / /  / __  / / / / / / __  / _ \/ ___/
 / / / / / /  __/   ___/ / /_/ /_/ / /  / /_/ /  / /_/ / /_/ / / / /_/ /  __/ /    
/_/ /_/ /_/\___/   /____/\__/\____/_/   \__, /  /_____/\__,_/_/_/\__,_/\___/_/     
                                       /____/                                                                                        
";

            ForegroundColor = ConsoleColor.Green;
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    Build();
                    break;
                case 1:
                    Documentation();
                    break;
                case 2:
                    Demo();
                    break;
                case 3:
                    ExitGame();
                    break;
            }
        }
        private void ExitGame()
        {
            Environment.Exit(0);
        }

        private void Build()
        {

        }

        private void Demo()
        {

        }

        private void Documentation()
        {

        }

    }
}
