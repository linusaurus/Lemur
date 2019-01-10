using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PurchaseSQLDB.DataAccess.EFCode;
using PurchaseSQLDB.DataAccess.EFClasses;
using Weaselware.Lemur.Services;

namespace Weaselware.Lemur.Pages
{
    public class SuppliersFilterModel : PageModel
    {
        
        private readonly Services.SuppliersList _supplierList;

        public SuppliersFilterModel(SuppliersList suppliersList)
        {
            _supplierList = suppliersList;
        }
        
        public JsonResult OnGet([FromQuery]string term)
        {
            //search = "sher";
            return new JsonResult(_supplierList.GetFilterDropDownValues(term));
        }
    }
}