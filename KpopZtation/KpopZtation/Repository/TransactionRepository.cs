﻿using KpopZtation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KpopZtation.Repository
{
    public class TransactionRepository
    {
        public static ModelKpopZtationEntities db = Connect.getInstances();

        public static List<TransactionHeader> GetTransactions(int customerId)
        {
            return (db.TransactionHeaders.Where(x => x.CustomerId == customerId)).ToList();
        }

        public static List<TransactionDetail> getTransactionById(String transactionId)
        {
            int actualId = int.Parse(transactionId);
            return (db.TransactionDetails.Where(x => x.TransactionId == actualId)).ToList();
        }

        public static Customer getCustomerId(String email)
        {
            return (db.Customers.Where(x => x.CustomerEmail.Equals(email))).FirstOrDefault();
        }

    }
}