using System;
using Xunit;
using Weaselware.Lemur;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurchaseSQLDB.DataAccess.EFCode;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.InMemory;
using Weaselware.Lemur.Pages;
using Weaselware.Lemur.Test;
using Weaselware.Lemur.Services;
using System.Threading.Tasks;
using Weaselware.Lemur.DTO;
using PurchaseSQLDB.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;

namespace Weaselware.Lemur.Test
{
    public class UnitTest1
    {
       

        [Fact]
        public void TestProjectsMappingEmployees()
        {
             
            
       

            using (var db = new PurchaseSQLDBContext(Utilites.TestDbContextOptions()))
            {

                //var part = db.Part.Include(d => d.PartsLink).Where(c => c.PartID == 5717).SingleOrDefault();
                var r = db.Part.Include(d => d.PartsLink).Where(c => c.PartID == 5720).Select(p => new PartEditDto
                {
                    PartID = p.PartID,
                    Description = p.ItemDescription,
                    SupplierDescription = p.SupplierDescription,
                    ItemName = p.ItemName,
                    PartNumber = p.PartNum,
                    SupplierID = p.SupplierID.Value,
                    Location = p.Location,
                    SupplierName = p.Supplier.SupplierName,
                    Manufacturer = db.Manu.Where(f => f.ManuID == p.ManuID).Select(d => d.Manufacturer).FirstOrDefault().ToString(),
                    DateAdded = p.DateAdded.HasValue ? p.DateAdded.Value : DateTime.Today,
                    LastModified = p.ModifiedDate.HasValue ? p.ModifiedDate.Value : DateTime.Today,
                    ManuID = p.ManuID.HasValue ? p.ManuID.Value : 0,
                    ManuPartNum = p.ManuPartNum,
                    //PartTypeID = p.PartTypeID.HasValue ? p.PartTypeID.Value : 0,
                    ModifiedBy = p.ModifiedBy,
                    Cost = p.Cost.Value,
                    UID = p.UID.HasValue ? p.UID.Value : 0,
                    UnitOfMeasure = db.UnitOfMeasure.Where(o => o.UID == p.UID).Select(e => e.UOM).SingleOrDefault().ToString(),
                    Weight = p.Weight.Value,
                    Waste = p.Waste.Value,
                    MarkUp = p.MarkUp.Value,
                    SKU = p.SKU,
                    UseSupplierName = p.UseSupplierNameFlag,
                    Documents = p.PartsLink.Select(f => new PartDocumentsDto
                    {
                        DocID = f.Documents.DocID,
                        Description = f.Documents.Description,
                        DocumentView = f.Documents.DocumentView,
                        Path = f.Documents.DocumentPath

                    }).ToList()

                }).SingleOrDefault();

                var text = r;
                Assert.True(r.PartID == 5720);

            }




        }

        [Fact]
        public void TestJobDetail()
        {

            using (var db = new PurchaseSQLDBContext(Utilites.TestDbContextOptions()))
            {


                var n = db.Job.Where(c => c.job_id == 1265).Select(p => new JobDetailsDto
                {
                    JobID = p.job_id,
                    JobName = p.jobname,
                    JobCostName = p.jobdesc,
                    JobOrdersTotal = p.PurchaseOrders.Count> 0 ? p.PurchaseOrders.Sum(w => w.OrderTotal).Value : 0.0m,
                    JobOrders = db.PurchaseOrder.Where(d => d.Job_id == 1265).Select(s => new OrderDto
                    {
                        PurchaseOrderID = s.OrderNum,
                        OrderDate = s.OrderDate.ToShortDateString(),
                        Purchaser = s.Employee.lastname,
                        Supplier = s.Supplier.SupplierName,
                        OrderTotal = s.OrderTotal.Value.ToString(),
                        Received = s.Recieved.Value
                    }).ToList()


                }).SingleOrDefault();

                Assert.True(n.JobID == 1265);
               ;
            }

            
        }

        [Fact]
        public async void TestInventoryGet()
        {

           
            Assert.True(n.JobID == 1265);
                
         }


        

    }
}
