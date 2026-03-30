using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace PROG_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\Audio\Greeting.wav";   //path to the welcome audio file

            Console.WriteLine(" _       _____  _______ _     _ _______ _______ _____ _______ _     _"); //ASCII art for the welcome message
            Console.WriteLine(" |      |     | |       |____/  |______ |  |  |   |      |    |_____|");
            Console.WriteLine(" |_____ |_____| |_____  |    \\_ ______| |  |  | __|__    |    |     |");
            Console.WriteLine("     .--.                  .--.                  .--.            ");
            Console.WriteLine("    /.-. '----------.     /.-. '----------.     /.-. '----------.");
            Console.WriteLine("    \'-' .---'-''-'-'     \'-' .--'--''-'-'     \'-' .--'--'-''-'");
            Console.WriteLine("     '--'                  '--'                  '--'  ");
            Console.WriteLine("A Chatbot by LOCKSMITH SOLUTIONS");


            SoundPlayer player = new SoundPlayer(path); //new soundplayer object to play the wav greeting file
            player.PlaySync();  //play the greeting file synchronously

            Console.WriteLine("-------------[MENU]-------------");


            int status = 1;    //status variable to control the while loop

            while(status != 0)  //main loop for the program a status of 1 will keep the program running, a status of 0 will end the program
            {
                Console.WriteLine ("while test");
                string input = Console.ReadLine();
                status = int.Parse (input);
                Console.WriteLine ("status: " + status);
            }

            User user = new User();    //create a new user object to access the user class


        }
    }
}
