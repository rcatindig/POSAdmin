using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using TMAAdmin.Models;
using System.Data.Entity;

namespace TMAAdmin.DAL
{
    public class TransactionRepository : ITransactionRepository, IDisposable
    {
        private TMAAdminContext context;

        public TransactionRepository(TMAAdminContext context)
        {
            this.context = context;
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return context.Transactions.ToList();
        }

        public Transaction GetTransactionByID(int id)
        {
            return context.Transactions.Find(id);
        }

        public void InsertTransaction(Transaction transaction)
        {
            context.Transactions.Add(transaction);
        }

        public void DeleteTransaction(int transactionID)
        {
            Transaction transaction = context.Transactions.Find(transactionID);
            context.Transactions.Remove(transaction);
        }

        public void UpdateTransaction(Transaction transaction)
        {
            context.Entry(transaction).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}