using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApp.Models
{
    public class Client : User
    {
        // Dodatkowe właściwości klienta np. numer karnetu, stan zdrowia itd.
        //test
        public override string GetUserType()
        {
            return "Client";
        }
    }
}

