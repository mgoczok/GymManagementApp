using System;

namespace GymManagementApp.Models
{
    public abstract class Training
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int GroupId { get; set; }

        public abstract string TrainingType { get; }

        protected Training() { }
        public abstract void Describe();
    }
}


