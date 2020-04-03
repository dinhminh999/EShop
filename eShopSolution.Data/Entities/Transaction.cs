using eShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public int TransactionDate { get; set; }
        public int ExternalTransactionId { get; set; }
        public int Amount { get; set; }
        public int Fee { get; set; }
        public int Result { get; set; }
        public string Message { get; set; }
        public Status Status { get; set; }
        public int Providers { get; set; }
    }
}
