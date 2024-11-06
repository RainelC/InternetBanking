﻿namespace InternetBanking.Core.Domain.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int SourceAccount {  get; set; }
        public int DestinationAccount {  get; set; }
    }
}
