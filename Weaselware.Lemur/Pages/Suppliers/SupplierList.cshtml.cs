using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PurchaseSQLDB.DataAccess.EFClasses;
using PurchaseSQLDB.DataAccess.EFCode;
using Weaselware.Lemur.DTO;

namespace Weaselware.Lemur.Pages.Suppliers
{
    public class SupplierListModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;
        public string CurrentFilter { get; set; }
        public int pageIndex;

        [BindProperty]
        public PaginatedList<SuppliersListDto> Suppliers { get; set; }

        public SupplierListModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

       
        public async Task OnGetAsync(string currentFilter, string searchString, int? pageIndex)
        {

            IQueryable<SuppliersListDto> SupplierIQ = _context.Supplier.Select(p => new SuppliersListDto
            {
                SupplierID = p.SupplierID,
                SupplierName = p.SupplierName,
                OrderTotals = p.PurchaseOrders.Where(d=> d.SupplierID==p.SupplierID).Sum(s=> s.OrderTotal).Value
               
            }).OrderBy(d => d.SupplierID);

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
  
             SupplierIQ = SupplierIQ.Where(l => l.SupplierName.Contains( searchString));     
            }

            int pageSize = 16;
            Suppliers = await PaginatedList<SuppliersListDto>.CreateAsync(
                SupplierIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

        }
    }
}