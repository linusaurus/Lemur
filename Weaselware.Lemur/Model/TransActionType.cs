using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseSQLDB.DataAccess.EFClasses;

namespace PurchaseSQLDB.DataAccess.EFClasses
{
    public class TransActionType
    {
        public int TransactionsTypeID { get; set; }
        public string TransactionTypeName { get; set; }
    }
}
