namespace GymManagementApp.Models
{
    public class CardioTraining : Training
    {
        public override string TrainingType => "Cardio";
        public int DurationMinutes { get; set; }
        public override void Describe() {}
    }
}

