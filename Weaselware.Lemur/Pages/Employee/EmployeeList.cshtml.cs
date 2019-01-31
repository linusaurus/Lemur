using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PurchaseSQLDB.DataAccess.EFCode;
using PurchaseSQLDB.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Weaselware.Lemur.DTO;


namespace Weaselware.Lemur.Pages.Employee
{
    public class EmployeeListModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;
        public string CurrentFilter { get; set; }
        public int pageIndex;
        public PaginatedList<EmployeeListDto> Employees { get; set; }



        public EmployeeListModel(PurchaseSQLDBContext context)
        {
            _context = context;
          
        }
        
        public async Task OnGetAsync(string currentFilter, string searchString, int? pageIndex)
        {

            IQueryable<EmployeeListDto> EmployeeIQ = _context.Employee.Where(f => f.IsPurchaser ==true).Select(p => new EmployeeListDto
            {
                EmployeeID = p.employeeID,
                IsPurchaser = p.IsPurchaser.Value,
                Name = String.Format("{0} {1} {2}",p.firstname,p.middlename,p.lastname),
                Email = p.EmployeeEmail   
            }).OrderByDescending(d => d.EmployeeID);

            //CurrentFilter = searchString;

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
    
             EmployeeIQ = EmployeeIQ.Where(s => s.Name.Contains(searchString));
                
            }

            int pageSize = 16;
            Employees = await PaginatedList<EmployeeListDto>.CreateAsync(
                EmployeeIQ.AsNoTracking(), pageIndex ?? 1, pageSize);

        }


    }
}