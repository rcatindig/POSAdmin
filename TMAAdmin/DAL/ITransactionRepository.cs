using System;
using System.Collections.Generic;
using TMAAdmin.Models;

namespace TMAAdmin.DAL
{
    public interface ITransactionRepository : IDisposable
    {
        IEnumerable<Transaction> GetTransactions();
        Transaction GetTransactionByID(int transactionID);
        void InsertTransaction(Transaction transaction);
        void DeleteTransaction(int transactionID);
        void UpdateTransaction(Transaction student);
        void Save();
    }
}