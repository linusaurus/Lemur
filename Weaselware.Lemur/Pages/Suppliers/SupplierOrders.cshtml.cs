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

namespace Weaselware.Lemur.Pages.Suppliers
{
    public class SupplierOrdersModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;
        public string CurrentFilter { get; set; }
        public int SupplierID { get; set; }
        public int pageIndex;
        public PaginatedList<OrderDto> SupplierOrders { get; set; }

        public SupplierOrdersModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int id ,int? pageIndex)
        {
            SupplierID = id;
            IQueryable<OrderDto> SupplierOrdersIQ = _context.PurchaseOrder.Where(s=> s.SupplierID==id).Select(p => new OrderDto
            {
                PurchaseOrderID = p.OrderNum,
                Supplier = p.Supplier.SupplierName,
                Purchaser = String.Format("{0} {1}",p.Employee.firstname, p.Employee.lastname),
                JobName = p.Job.jobname,
                OrderDate = p.OrderDate.ToShortDateString(),
                OrderTotal = p.OrderTotal.Value.ToString()

            }).OrderByDescending(d => d.PurchaseOrderID);

           

            int pageSize = 16;
            SupplierOrders = await PaginatedList<OrderDto>.CreateAsync(
                SupplierOrdersIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

        }

        //public async Task OnGetAsync(string currentFilter, string searchString, int? pageIndex)
        //{

        //    IQueryable<OrderDto> SupplierOrdersIQ = _context.PurchaseOrder.Select(p => new OrderDto
        //    {
        //        PurchaseOrderID = p.OrderNum,
        //        Supplier = p.Supplier.SupplierName,
        //        Purchaser = p.Employee.lastname,
        //        JobName = p.Job.jobname,
        //        OrderDate = p.OrderDate.ToShortDateString(),
        //        OrderTotal = p.OrderTotal.Value.ToString()

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

        //        SupplierOrdersIQ = SupplierOrdersIQ.Where(l => l.Supplier.Contains(searchString));
        //    }

        //    int pageSize = 16;
        //    SupplierOrders = await PaginatedList<OrderDto>.CreateAsync(
        //        SupplierOrdersIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

        //}
    }
}