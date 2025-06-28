using System;

namespace GymManagementApp.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string PaymentType { get; set; } = string.Empty;

        
    }
}

