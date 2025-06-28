namespace GymManagementApp.Models
{
    public class StrengthTraining : Training
    {
        public override string TrainingType => "Strength";
        public int Sets { get; set; }
        public override void Describe() {}
    }
}

