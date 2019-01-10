using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PurchaseSQLDB.DataAccess.EFClasses;
using PurchaseSQLDB.DataAccess.EFCode;

namespace Weaselware.Lemur.Pages.Test
{
    public class indexModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;

        public string CurrentFilter { get; set; }
        public int pageIndex;
        public PaginatedList<NFRC> NFCRs { get; set; }



        public indexModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string currentFilter, string searchString, int? pageIndex)
        {


            CurrentFilter = searchString;

            //IQueryable<Job> testIQ = from s in _context.NFCR select s;
            IQueryable<NFRC> nfcrIQ = _context.NFRC.Select(s => s).OrderByDescending(m => m.CPD);

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
                nfcrIQ = nfcrIQ.Where(s => s.CPD.Contains(searchString)
                                      || s.UnitType.Contains(searchString));
            }

            int pageSize = 16;
            NFCRs = await PaginatedList<NFRC>.CreateAsync(
                nfcrIQ.AsNoTracking(), pageIndex ?? 1, pageSize);


        }
    }
}