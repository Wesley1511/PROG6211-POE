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

        public void StartChat()
        {
            Console.WriteLine("[CyberSafe] Hello!, my name is CyberSafe and I will be your cybersecurity assistant today! Please tell me your name so we can get started!");

        }

    }
}
