using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace PROG_POE
{
    internal class Chat
    {
        User ChatUser = null;
        ChatBot ChatBot = null;

        public Chat(User user, ChatBot chatbot)
        {
            ChatUser = user;
            ChatBot = chatbot;
        }

        public void setChatUser(User user)
        {
            ChatUser = user;
        }

        public void setChatBot(ChatBot bot)
        {
            ChatBot = bot;
        }

        public ChatBot getChatBot()
        {
            return ChatBot;
        }

        public User getChatUser()
        {
            return ChatUser;
        }

        public void StartChat() //main function for the chat class, starts the chat and handles the conversation flow between the user and the chatbot
        {

            Thread.Sleep(1000); //collection of thread sleep commands to create a loading effect for the user
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------[CHAT INITIALIZING]-------------");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------[CONNECTING.......]-------------");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------[    CONNECTED    ]-------------");
            Thread.Sleep(1000);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[CyberSafe] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello!, my name is CyberSafe and I will be your cybersecurity assistant today! Please tell me your name so we can get started!");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Name: ");
            String name = ChatUser.GetUserInput();
            ChatUser.SetUserName(name);

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[CyberSafe] ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Nice to meet you " + ChatUser.GetUserName() + "! How can I assist you today? You can ask me any question about cybersecurity and I will do my best to help you! You can type");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" EXIT ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("at any time to close our chat!");

            int chatStatus = 1; //variable to keep track of the chat status, if the user wants to end the chat it will be set to 0 and the chat will end

            while (chatStatus == 1) //main for loop for the chat function
            {
                string userInput = "";
                string botResponse = "";

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("[" + ChatUser.GetUserName() + "]" + " ");
                Console.ForegroundColor = ConsoleColor.Gray;
                userInput = ChatUser.GetUserInput();
                botResponse = ChatBot.GetChatBotResponse(userInput);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("[" + ChatBot.GetChatBotName() + "]" + " ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("...THINKING...");
                Thread.Sleep(2000);

                Console.SetCursorPosition(0, Console.CursorTop - 1); //moves the cursor up one line to overwrite the "thinking" message with the actual response from the chatbot

                Console.Write(new string(' ', Console.WindowWidth));

                Console.SetCursorPosition(0, Console.CursorTop); //moves the cursor back to the beginning of the line after clearing it

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("[" + ChatBot.GetChatBotName() + "]" + " ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(botResponse);

                if (userInput == "EXIT") //if the user types EXIT, the chat will end
                {

                    Thread.Sleep(1000); //collection of thread sleep commands to create a loading effect for the user
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-------------[CHAT ENDING]-------------------");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("-------------[DISCONNECTING]-----------------");
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("-------------[CHAT DISCONNECTED]-------------");
                    Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.White;

                    chatStatus = 0;
                }
            }
        }

    }
}
