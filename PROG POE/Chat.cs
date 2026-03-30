using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("[CyberSafe] Hello!, my name is CyberSafe and I will be your cybersecurity assistant today! Please tell me your name so we can get started!");
            Console.Write("Name: ");
            String name = ChatUser.GetUserInput();
            ChatUser.SetUserName(name);
            Console.WriteLine("[CyberSafe] Nice to meet you " + ChatUser.GetUserName() + "! How can I assist you today? You can ask me any question about cybersecurity and I will do my best to help you!");

            int chatStatus = 1; //variable to keep track of the chat status, if the user wants to end the chat it will be set to 0 and the chat will end

            while (chatStatus == 1) //main for loop for the chat function
            {

            }
        }

    }
}
