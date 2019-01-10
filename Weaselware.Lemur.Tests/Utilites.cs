using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PurchaseSQLDB.DataAccess.EFCode;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace Weaselware.Lemur.Test
{ 
    public class Utilites
    {

            public static DbContextOptions<PurchaseSQLDBContext> TestDbContextOptions()
            {
            // Create a new service provider to create a new in-memory database.
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkInMemoryDatabase()
                .BuildServiceProvider();

            

            // Create a new options instance using an in-memory database and 
            // IServiceProvider that the context should resolve all of its 
            // services from.
            //var builder = new DbContextOptionsBuilder<PurchaseSQLDBContext>()
            //    .UseInMemoryDatabase("InMemoryDb")
            //   .UseInternalServiceProvider(serviceProvider);

            var builder = new DbContextOptionsBuilder<PurchaseSQLDBContext>()
               .UseSqlServer("Data Source=192.168.10.3;Initial Catalog=Badger;User ID=sa;Password=Kx09a32x;");
              

            return builder.Options;
            }

    }
}
