using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PurchaseSQLDB.DataAccess.EFClasses;
using PurchaseSQLDB.DataAccess.EFCode;
using Weaselware.Lemur.DTO;



namespace Weaselware.Lemur.Services
{
   
    public class InventoryService
    {
        private readonly PurchaseSQLDBContext _db;

        public InventoryService(PurchaseSQLDBContext db)
        {
            _db = db;
        }

        public async Task<List<InventoryDto>> GetAll()
        {
            return await _db.Inventory.Select(p => new InventoryDto
            {
                StockTransactionID = p.StockTransactionID,
                Description = p.Description,
                DateStamp = p.DateStamp.HasValue ? p.DateStamp.Value : DateTime.Today,
                LineID = p.LineID.HasValue ? p.LineID.Value: 0,
                Location = p.Location,
                OrderReceiptID = p.OrderReceiptID.HasValue ? p.OrderReceiptID.Value : 0,
                PartID = p.PartID.Value > 0 ? p.PartID.Value : 0,
                Qnty = p.Qnty.HasValue ? p.Qnty.Value : 0,
                



            }).ToListAsync();
        }
    }
}
