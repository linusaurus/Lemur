using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PurchaseSQLDB.DataAccess.EFClasses;
using PurchaseSQLDB.DataAccess.EFCode;
using Microsoft.EntityFrameworkCore;
using Weaselware.Lemur.DTO;

namespace Weaselware.Lemur.Pages.Orders
{
    public class indexModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;

        public string CurrentFilter { get; set; }
        public int pageIndex;
        public PaginatedList<OrderDto> Orders { get; set; }



        public indexModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string currentFilter,string searchString, int? pageIndex)
        {

            IQueryable<OrderDto> OrderIQ = _context.PurchaseOrder.Select(p => new OrderDto
            {
                PurchaseOrderID = p.OrderNum,
                OrderDate = p.OrderDate.ToShortDateString(),
                Supplier = p.Supplier.SupplierName,
                JobName = p.Job.jobname,
                Purchaser = p.Employee.firstname + " " + p.Employee.lastname,
                OrderTotal = p.OrderTotal.ToString(),
                Received = p.Recieved.Value         
            }).OrderByDescending(d => d.PurchaseOrderID);

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
                int orderNumber;
                bool sucess = Int32.TryParse(searchString, out orderNumber);
                if (sucess)
                {
                    OrderIQ = OrderIQ.Where(l => l.PurchaseOrderID == orderNumber);
                }
                else
                {
                    OrderIQ = OrderIQ.Where(s => s.JobName.Contains(searchString) || s.Supplier.Contains(searchString));
                }
            }

            int pageSize = 16;
            Orders = await PaginatedList<OrderDto>.CreateAsync(
                OrderIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

        }


    }
}