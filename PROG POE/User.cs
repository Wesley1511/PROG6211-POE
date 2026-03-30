using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG_POE
{
    internal class User
    {
        string name = "User";

        public string GetUserName()
        {
            return name;
        }

        public void SetUserName(string newName)
        {
            name = newName;
        }

        public string GetUserInput()        //main user class function for getting the users input
        {
            string input = Console.ReadLine();
            return input;
        }

    }
}
