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
using System.Collections.Generic;
using Weaselware.Lemur.Services;
using System.Threading.Tasks;
using Weaselware.Lemur.DTO;
using PurchaseSQLDB.DataAccess.EFClasses;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Linq;


namespace Weaselware.Lemur.Test
{
    public class InventoryUnitTest
    {
       

        [Fact]
        public async Task TestInventoryGetAll()
        {

            var result = new List<InventoryDto>();
       

            using (var db = new PurchaseSQLDBContext(Utilites.TestDbContextOptions()))
            {
                var  _service = new InventoryService(db);
                result = await _service.GetAll();
               
            }


            Assert.True(result.Count() >1200);

        }

        [Fact]
        public async Task TestInventoryGetTransActions()
        {

            var result = new List<InventoryDto>();


            using (var db = new PurchaseSQLDBContext(Utilites.TestDbContextOptions()))
            {
                var _service = new InventoryService(db);
                result = await _service.GetTransActions(3613);

            }


            Assert.True(result.Count() ==6);

        }

        [Fact]
        public async Task TestInventoryGetStockLevel()
        {

            decimal result; 


            using (var db = new PurchaseSQLDBContext(Utilites.TestDbContextOptions()))
            {
                var _service = new InventoryService(db);
                result = await _service.GetStockLevel(3354);

            }


            Assert.True(result == 0.0m);

        }

        [Fact]
        public async Task TestInventoryPushPart()
        {

            decimal result;
            decimal after;

            using (var db = new PurchaseSQLDBContext(Utilites.TestDbContextOptions()))
            {
             

                var _service = new InventoryService(db);
                result = await _service.GetStockLevel(3354);
                _service.PushPart(3354, 10.0m);
                after = await _service.GetStockLevel(3354);
            }

            

           


            Assert.True(after  == result + 10.0m);

        }






    }
}
