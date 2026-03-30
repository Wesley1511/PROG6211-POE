using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace PROG_POE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\Audio\Greeting.wav";   //path to the welcome audio file

            User user = new User();    //create a new user object to access the user class
            ChatBot bot = new ChatBot();  //create a new chatbot object to access the chatbot class
            Chat chat = new Chat(user, bot);    //create a new chat object to access the chat class


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

            chat.StartChat();



        }
    }
}
