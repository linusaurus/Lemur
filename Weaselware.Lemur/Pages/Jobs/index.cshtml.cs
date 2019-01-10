using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PurchaseSQLDB.DataAccess.EFCode;
using PurchaseSQLDB.DataAccess.EFClasses;



namespace Weaselware.Lemur.Pages.Jobs
{
    public class indexModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;

        public string CurrentFilter { get; set; }
        public int pageIndex;
        public PaginatedList<Job> Jobs { get; set; }



        public indexModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync(string currentFilter, string searchString ,int? pageIndex)
        {

           
            CurrentFilter = searchString;

            //IQueryable<Job> JobIQ = from s in _context.Job select s;
            IQueryable<Job> JobIQ = _context.Job.Select(s => s).OrderByDescending(m => m.job_id);

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
                JobIQ = JobIQ.Where(s => s.jobname.Contains(searchString)
                                       || s.jobdesc.Contains(searchString)).OrderByDescending(m=> m.job_id);
            }

            int pageSize = 16;
            Jobs = await PaginatedList<Job>.CreateAsync(
                JobIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

            
        }


    }
} 