using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace TMAAdmin.Models
{
    public class Transaction
    {
        
        
        public string Company { get; set; }
        public DateTime TransactionDate { get; set; }

        [Key]
        public string Epan { get; set; }

        public string LicensePlate { get; set; }
        public int UserId { get; set; }
        public string MachineId { get; set; }
        public string SerialNumber { get; set; }
        public string UniqueTransactionNumber { get; set; }
        public string ReceiptNumber { get; set; }
        public DateTime EntryDateTime { get; set; }
        public DateTime ExitDateTime { get; set; }
        public string Duration { get; set; }
        public int Tariff { get; set; }
        public float TotalAmount { get; set; }
        public float AcceptedTotal { get; set; }
        public float NetTotal { get; set; }
        public float Vat { get; set; }
    }
}