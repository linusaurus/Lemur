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

namespace Weaselware.Lemur.Pages.Jobs
{
    public class JobOrdersModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;
        public string CurrentFilter { get; set; }
        public int JobID { get; set; }
        public int pageIndex;
        public PaginatedList<OrderDto> JobOrders { get; set; }

        public JobOrdersModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int id, int? pageIndex)
        {
            JobID = id;
            IQueryable<OrderDto> SupplierOrdersIQ = _context.PurchaseOrder.Where(s => s.SupplierID == id).Select(p => new OrderDto
            {
                PurchaseOrderID = p.OrderNum,
                Supplier = p.Supplier.SupplierName,
                Purchaser = String.Format("{0} {1}", p.Employee.firstname, p.Employee.lastname),
                JobName = p.Job.jobname,
                OrderDate = p.OrderDate.ToShortDateString(),
                OrderTotal = p.OrderTotal.Value.ToString()

            }).OrderByDescending(d => d.PurchaseOrderID);



            int pageSize = 16;
            JobOrders = await PaginatedList<OrderDto>.CreateAsync(
                SupplierOrdersIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

        }
    }
}