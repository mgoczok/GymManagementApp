using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApp.Models
{
    public class User
    {
        private int id;
        private string name;
        private string email;

        // hermetyzacja pól

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }

        public string Password { get; set; }

        public virtual string GetUserType()
        {
            return "User";
        }
    }
}