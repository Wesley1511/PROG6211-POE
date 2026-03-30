using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE
{
    internal class ChatBot
    {
        string name = "CyberSafe";

        public void SetChatBotName(string Name)
        {
            name = Name;    
        }

        public string GetChatBotName()
        {
            return name;
        }

        public string GetChatBotResponse(string input)
        {
            Response Botresponse = new Response();

            String response = Botresponse.Respond(input);

            return response;
        }


    }
}
