using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementApp.Models
{
    public class TrainingGroup
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // (opcjonalnie) nadpisz ToString, aby wyświetlało nazwę
        public override string ToString()
        {
            return Name;
        }
    }
}
