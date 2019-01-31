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

namespace Weaselware.Lemur.Pages.Parts
{
    public class indexModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;

        public string CurrentFilter { get; set; }
        public int pageIndex;
        public PaginatedList<PartDto> Parts { get; set; }



        public indexModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string currentFilter, string searchString, int? pageIndex)
        {

            
            if (searchString != null)
            {
                pageIndex = 1;               
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            IQueryable<PartDto> PartIQ = _context.Part.Select(p => new PartDto
            {
                PartID = p.PartID,
                Description = p.ItemDescription.Substring(0,78),
                PartNumber = p.ItemName,
                Location = p.Location,
                SKU = p.SKU,
                UnitInStock = _context.Inventory.Where(h=> h.PartID==p.PartID).Sum(r=> r.Qnty).GetValueOrDefault(),
            }).OrderByDescending(s => s.PartID);

            if (!String.IsNullOrEmpty(searchString))
            {
                int orderNumber;
                bool sucess = Int32.TryParse(searchString, out orderNumber);
                if (sucess)
                {
                    PartIQ = PartIQ.Where(s => s.PartID.Equals(orderNumber)).OrderByDescending(s=> s.PartID);
                }
                else
                {
                    PartIQ = PartIQ.Where(s => s.Description.Contains(searchString)).OrderByDescending(s => s.PartID);
                }

                
            }

            int pageSize = 16;
            Parts = await PaginatedList<PartDto>.CreateAsync(
                PartIQ.AsNoTracking(), pageIndex ?? 1, pageSize);


        }


    }
}