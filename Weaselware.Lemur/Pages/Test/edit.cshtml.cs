using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PurchaseSQLDB.DataAccess.EFClasses;
using PurchaseSQLDB.DataAccess.EFCode;

namespace Weaselware.Lemur.Pages.Test
{
    public class editModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;
        public NFRC GetNFRC { get; set; }

        public editModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        public void OnGet(int id)
        {
            GetNFRC = _context.NFRC.Where(p => p.CPD_ID == id).FirstOrDefault();

        }
    }
}