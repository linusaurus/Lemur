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
        public PaginatedList<PurchaseSQLDB.DataAccess.EFClasses.Inventory> Inventories { get; set; }

        public InventoryListModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        //public async Task OnGetAsync(string currentFilter, string searchString, int? pageIndex)
        //{

        //    IQueryable<OrderDto> OrderIQ = _context.PurchaseOrder.Select(p => new OrderDto
        //    {
        //        PurchaseOrderID = p.OrderNum,
        //        OrderDate = p.OrderDate.ToShortDateString(),
        //        Supplier = p.Supplier.SupplierName,
        //        JobName = p.Job.jobname,
        //        Purchaser = p.Employee.firstname + " " + p.Employee.lastname,
        //        OrderTotal = p.OrderTotal.ToString()
        //    }).OrderByDescending(d => d.PurchaseOrderID);

        //    CurrentFilter = searchString;

        //    if (searchString != null)
        //    {
        //        pageIndex = 1;
        //    }
        //    else
        //    {
        //        searchString = currentFilter;
        //    }

        //    CurrentFilter = searchString;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        int orderNumber;
        //        bool sucess = Int32.TryParse(searchString, out orderNumber);
        //        if (sucess)
        //        {
        //            OrderIQ = OrderIQ.Where(l => l.PurchaseOrderID == orderNumber);
        //        }
        //        else
        //        {
        //            OrderIQ = OrderIQ.Where(s => s.JobName.Contains(searchString) || s.Supplier.Contains(searchString));
        //        }
        //    }

        //    int pageSize = 16;
        //    Inventories = await PaginatedList<OrderDto>.CreateAsync(
        //        OrderIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

        //}
    }
}