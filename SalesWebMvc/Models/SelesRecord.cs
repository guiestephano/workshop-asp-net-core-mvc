using System;
using SalesWebMvc.Models.Enums;


namespace SalesWebMvc.Models
{
    public class SelesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SeleStatus Status { get; set; }
        public Seller Seller { get; set; }

        public SelesRecord() { }
        public SelesRecord(int id, DateTime date, double amount, SeleStatus status, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Seller = seller;
        }
    }
}
