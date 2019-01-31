using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PurchaseSQLDB.DataAccess.EFClasses;
using PurchaseSQLDB.DataAccess.EFCode;
using Weaselware.Lemur.DTO;

namespace Weaselware.Lemur.Pages.Inventory
{
    public class InventoryListModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;

        public string CurrentFilter { get; set; }
        public int pageIndex;
        public PaginatedList<InventoryDto> Inventories { get; set; }

        public InventoryListModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string currentFilter, string searchString, int? pageIndex)
        {

            IQueryable<InventoryDto> InventoryIQ = _context.Inventory.Select(p => new InventoryDto
            {
                PartID = p.PartID,
                StockTransactionID = p.StockTransactionID,
                LineID = p.LineID.GetValueOrDefault(),
                Description = p.Description.Substring(0,85),
                DateStamp = p.DateStamp.HasValue ? p.DateStamp.Value.ToShortDateString() : String.Empty,
                OrderReceiptID = p.OrderReceiptID.GetValueOrDefault(),
                PurchaseOrderID = p.OrderReciept.OrderNum.HasValue ? p.OrderReciept.OrderNum.Value : 0,
                Location = p.Location,
                Qnty = p.Qnty.GetValueOrDefault(),
                StockBillID = p.StockBillID.GetValueOrDefault(),
                UID = p.UnitOfMeasure.GetValueOrDefault(),
                TransActionName = _context.UnitOfMeasure.Where(l => l.UID ==p.TransActionType).FirstOrDefault().UOM,
                
                
            }).OrderByDescending(d => d.StockTransactionID);

            CurrentFilter = searchString;

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                int stockTag;
                bool sucess = Int32.TryParse(searchString, out stockTag);
                if (sucess)
                {
                    InventoryIQ = InventoryIQ.Where(l => l.StockTransactionID == stockTag || l.PartID == stockTag);
                }
                else
                {
                    InventoryIQ = InventoryIQ.Where(s => s.Description.Contains(searchString) );
                }
            }

            int pageSize = 16;
            Inventories = await PaginatedList<InventoryDto>.CreateAsync(
                InventoryIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

        }

    }
}