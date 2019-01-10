using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PurchaseSQLDB.DataAccess.EFClasses;
using PurchaseSQLDB.DataAccess.EFCode;
using Weaselware.Lemur.DTO;

namespace Weaselware.Lemur.Pages.Jobs
{
    public class JobDetailModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;
        private readonly QQestContext _timeContext;

        public JobDetailModel(PurchaseSQLDBContext context,QQestContext timeContext)
        {
            _context = context;
            _timeContext = timeContext;
        }

        [BindProperty]
        public JobDetailsDto  _Job{ get; set; }

   
        public IQueryable<JobDetailsDto> JobIQ { get; set; }

        public void OnGet(int? id)
        {
            JobIQ = _context.Job.Where(c => c.job_id == id).Select(p => new JobDetailsDto
            {
                JobID = p.job_id,
                JobName = p.jobname,
                JobCostName = p.jobdesc,
                JobOrdersTotal = p.PurchaseOrders.Count > 0 ? p.PurchaseOrders.Sum(w => w.OrderTotal).Value : 0.0m,
                
                JobOrders = _context.PurchaseOrder.Where(d => d.Job_id == id).Select(s => new OrderDto
                {
                    PurchaseOrderID = s.OrderNum,
                    OrderDate = s.OrderDate.ToShortDateString(),
                    Purchaser = s.Employee.lastname,
                    Supplier = s.Supplier.SupplierName,
                    OrderTotal = s.OrderTotal.Value.ToString(),
                    Received = s.Recieved.Value
                }).ToList()


            });


           
            _Job = JobIQ.SingleOrDefault();
            _Job.JobLaborTotal = _timeContext.TimeCard.Where(j => j.job_id == id).Sum(f => f.total_hr);

        }
    }
}