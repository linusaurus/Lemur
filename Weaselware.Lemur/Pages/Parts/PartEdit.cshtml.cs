using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PurchaseSQLDB.DataAccess.EFCode;
using PurchaseSQLDB.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore;
using Weaselware.Lemur.DTO;

namespace Weaselware.Lemur.Pages.Parts
{
    public class PartEditModel : PageModel
    {
        private readonly PurchaseSQLDBContext _context;

        public PartEditModel(PurchaseSQLDBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public PartEditDto Part { get; set; }

        public IQueryable<PartEditDto> PartIQ { get; set; }
		

        public void  OnGet(int? id)
        {


            PartIQ = _context.Part.Include(d => d.PartsLink).Where(c => c.PartID == id).Select(p => new PartEditDto
            {
                PartID = p.PartID,
                Description = p.ItemDescription,
                ItemName = p.ItemName,
                SupplierDescription = p.SupplierDescription,
                PartNumber = p.PartNum,
                SupplierID = p.SupplierID.Value,
                Location = p.Location,
                SupplierName = p.Supplier.SupplierName,
                Manufacturer = _context.Manu.Where(f => f.ManuID == p.ManuID).Select(d => d.Manufacturer).FirstOrDefault().ToString(),
                DateAdded = p.DateAdded.HasValue ? p.DateAdded.Value : DateTime.Today,
                LastModified = p.ModifiedDate.HasValue ? p.ModifiedDate.Value : DateTime.Today,
                ManuID = p.ManuID.HasValue ? p.ManuID.Value : 1,
                ManuPartNum = p.ManuPartNum,
                //PartTypeID = p.PartTypeID.HasValue ? p.PartTypeID.Value : 0,
                //PartTypeName = p.PartTypeID.HasValue ? _context.PartType.Where(r => r.PartTypeID==p.PartTypeID).Select(s => s.),
                ModifiedBy = p.ModifiedBy,
                CreatedBy = p.AddedBy,
                Cost = p.Cost.Value,
                UID = p.UID.HasValue ? p.UID.Value : 0,
                UnitOfMeasure = _context.UnitOfMeasure.Where(o => o.UID == p.UID).Select(e => e.UOM).SingleOrDefault().ToString(),
                Weight = p.Weight.Value,
                Waste = p.Waste.Value,
                MarkUp = p.MarkUp.Value,
                SKU = p.SKU,
                UseSupplierName = p.UseSupplierNameFlag,
                StockOnHand = _context.Inventory.Where(
                    r => r.PartID == p.PartID).Sum(s => s.Qnty).HasValue ? _context.Inventory.Where(
                        r => r.PartID == p.PartID).Sum(s => s.Qnty).Value : 0.0m,
                Documents = p.PartsLink.Select(f => new PartDocumentsDto
                {
                    DocID = f.Documents.DocID,
                    Description = f.Documents.Description,
                    DocumentView = f.Documents.DocumentView,
                    Path = f.Documents.DocumentPath,
                    Creator= f.Documents.Creator,
                    DateCreated = f.Documents.DateCreated.HasValue ? f.Documents.DateCreated.Value : DateTime.Today

                }).ToList()

            });

       
                
            Part = PartIQ.SingleOrDefault();

           
           
        }

        public async Task<IActionResult> OnPostAsync(PartEditDto Part)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // Get the Part Entity--
            Part _part = _context.Part.Find(Part.PartID);
            _part.PartNum = Part.PartNumber;
            _part.ItemName = Part.ItemName;
           // _part.PartTypeID = Part.PartTypeID;
            _part.SKU = Part.SKU;
            _part.SupplierID = Part.SupplierID;
            _part.UID = Part.UID;
            _part.UseSupplierNameFlag = Part.UseSupplierName;
            _part.SupplierDescription = Part.SupplierDescription;
            _part.Waste = Part.Waste;
            _part.Weight = Part.Weight;
            _part.MarkUp = Part.MarkUp;
            _part.Cost = Part.Cost;
            _part.AddedBy = Part.CreatedBy;
            _part.DateAdded = Part.DateAdded;
            _part.ModifiedBy = Part.ModifiedBy;
            _part.ModifiedDate = Part.LastModified.HasValue ? Part.LastModified.Value : DateTime.Today;
            _part.ItemDescription = Part.Description;
            _part.Location = Part.Location;
            _part.ManuID = Part.ManuID.Value;
            _part.AddedBy = Part.CreatedBy;
           
            //_context.Attach(_part).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Part.Any(e => e.PartID == _part.PartID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./index");
        }
    }
}