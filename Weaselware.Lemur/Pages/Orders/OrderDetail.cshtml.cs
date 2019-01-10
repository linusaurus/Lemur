using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PurchaseSQLDB.DataAccess.EFClasses;
using PurchaseSQLDB.DataAccess.EFCode;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.AspNetCore.JsonPatch;
using System.ComponentModel.DataAnnotations;
using Weaselware.Lemur.DTO;



namespace Weaselware.Lemur.Pages.Orders
{
    public class OrderDetailModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;
        public OrderDetailDto Order { get; set; }



        public OrderDetailModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(int OrderID)
        {
            
            IQueryable<OrderDetailDto> OrderIQ = _context.PurchaseOrder.Include(a => a.PurchaseLineItems).Where(c => c.OrderNum == OrderID).Select(p => new OrderDetailDto
            {
                PurchaseOrderID = p.OrderNum,
                OrderDate = p.OrderDate.ToShortDateString(),
                SupplierName = p.Supplier.SupplierName,
                SupplierPhone = p.Supplier.Phone,
                JobName = p.Job.jobname,
                JobCostName = p.Job.jobdesc,
                Purchaser = p.Employee.firstname + " " + p.Employee.lastname,
                OrderTotal = p.OrderTotal.Value,
                JobID = p.Job_id.Value,
                SupplierAddress = p.Supplier.Address1,
                SupplierCity = p.Supplier.City,
                SupplierState = p.Supplier.State,
                SupplierZip = p.Supplier.Zip,           
                SubTotal = p.SubTotal.Value,
                Taxable = p.SuppressTax.HasValue ? p.SuppressTax.Value : false,
                Tax = p.Tax.HasValue ? p.Tax.Value : 0.00m,
                ShippingMethod = _context.ShipBy.Where(l=> l.ShipID == p.ShipID.Value).Select(a=> a.ShipByName).FirstOrDefault().ToString(),
                ShippingCost = p.ShippingCost.GetValueOrDefault(),
                LineItems = p.PurchaseLineItems.Select(dt => new LineItemDto
                {
                    LineID = dt.LineID,
                    Description = dt.Description,
                    PartID = dt.PartID,
                    Price = dt.UoPPrice.HasValue ? dt.UoPPrice.Value : 0.0m,
                    Extended = dt.Extended.HasValue ? dt.Extended.Value : 0.0m,
                    PurchaseOrderID = dt.PurchaseOrderID,
                    Quantity = dt.Qnty.HasValue ? dt.Qnty.Value : 0.0m
                }).ToList()
                
            });


            Order = await OrderIQ.FirstOrDefaultAsync();

        }
        


    }
}