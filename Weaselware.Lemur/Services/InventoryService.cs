using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PurchaseSQLDB.DataAccess.EFClasses;
using PurchaseSQLDB.DataAccess.EFCode;


namespace Weaselware.Lemur.Services
{
   
    public class InventoryService
    {
        private readonly PurchaseSQLDBContext _db;

        public InventoryService(PurchaseSQLDBContext db)
        {
            _db = db;
        }

        public async Task<>
    }
}
