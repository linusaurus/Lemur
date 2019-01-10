﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PurchaseSQLDB.DataAccess.EFCode;

namespace Weaselware.Lemur.Migrations
{
    [DbContext(typeof(QQestContext))]
    partial class PurchaseSQLDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArchRef");

                    b.Property<int?>("CPD_id");

                    b.Property<decimal?>("Depth");

                    b.Property<decimal?>("Height");

                    b.Property<bool?>("Make");

                    b.Property<string>("Note");

                    b.Property<bool?>("Omit");

                    b.Property<string>("ProductName");

                    b.Property<DateTime?>("ProductionDate");

                    b.Property<int?>("ProjectID");

                    b.Property<int?>("SystemFamilyID");

                    b.Property<decimal?>("Width");

                    b.HasKey("ProductID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.AccountType", b =>
                {
                    b.Property<int>("AccountTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("AccountTypeID");

                    b.ToTable("AccountType");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Article", b =>
                {
                    b.Property<int>("ArticleID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArchRef");

                    b.Property<string>("ArticleName");

                    b.Property<decimal?>("Depth");

                    b.Property<decimal?>("Height");

                    b.Property<string>("Note");

                    b.Property<DateTime?>("ProductionDate");

                    b.Property<int?>("ProjectID");

                    b.Property<decimal?>("Width");

                    b.HasKey("ArticleID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Attachment", b =>
                {
                    b.Property<int>("AttachmentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttachmentDescription");

                    b.Property<string>("Ext");

                    b.Property<int?>("OrderNum");

                    b.Property<string>("src");

                    b.HasKey("AttachmentID");

                    b.HasIndex("OrderNum");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Category", b =>
                {
                    b.Property<int>("Categoryid")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PartClassID");

                    b.HasKey("Categoryid");

                    b.HasIndex("PartClassID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Claim", b =>
                {
                    b.Property<int>("ClaimID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ClaimDate");

                    b.Property<int?>("EmployeeID");

                    b.Property<int?>("OrderNum");

                    b.Property<int?>("SupplierID");

                    b.Property<string>("SupplierOrder");

                    b.HasKey("ClaimID");

                    b.ToTable("Claim");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.ClaimDocument", b =>
                {
                    b.Property<int>("ClaimDocumentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClaimItemID");

                    b.Property<string>("DocumentDesciption");

                    b.Property<string>("DocumentExtension");

                    b.HasKey("ClaimDocumentID");

                    b.HasIndex("ClaimItemID");

                    b.ToTable("ClaimDocument");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.ClaimItem", b =>
                {
                    b.Property<int>("ClaimItemID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bcode");

                    b.Property<int?>("ClaimID");

                    b.Property<string>("DefectDescription");

                    b.Property<string>("Description");

                    b.Property<int?>("LineID");

                    b.Property<int?>("ProductID");

                    b.Property<int?>("TransActionType");

                    b.Property<int?>("partID");

                    b.HasKey("ClaimItemID");

                    b.HasIndex("ClaimID");

                    b.ToTable("ClaimItem");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Document", b =>
                {
                    b.Property<int>("DocID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<string>("DocumentPath");

                    b.Property<string>("DocumentView");

                    b.Property<int?>("PartID");

                    b.HasKey("DocID");

                    b.ToTable("Document");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.DocumentParts", b =>
                {
                    b.Property<int>("DocID");

                    b.Property<int>("PartID");

                    b.HasKey("DocID", "PartID");

                    b.HasIndex("PartID");

                    b.ToTable("DocumentParts");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Employee", b =>
                {
                    b.Property<int>("employeeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeEmail");

                    b.Property<bool?>("IsPurchaser");

                    b.Property<string>("Login");

                    b.Property<string>("Password");

                    b.Property<int?>("Role");

                    b.Property<bool?>("Show");

                    b.Property<string>("firstname");

                    b.Property<string>("lastname");

                    b.Property<string>("middlename");

                    b.HasKey("employeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Finish", b =>
                {
                    b.Property<int>("FinishID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FinishName");

                    b.HasKey("FinishID");

                    b.ToTable("Finish");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Globals", b =>
                {
                    b.Property<int>("GiD")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Data");

                    b.Property<string>("ElementName");

                    b.HasKey("GiD");

                    b.ToTable("Globals");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Inventory", b =>
                {
                    b.Property<int>("StockTransactionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ArticleID");

                    b.Property<DateTime?>("DateStamp");

                    b.Property<string>("Description");

                    b.Property<int?>("JobID");

                    b.Property<int?>("LineID");

                    b.Property<string>("Location");

                    b.Property<string>("Note");

                    b.Property<int?>("OrderReceiptID");

                    b.Property<int?>("PartID");

                    b.Property<decimal?>("Qnty");

                    b.Property<int?>("StockBillID");

                    b.Property<int?>("TransActionType");

                    b.Property<int?>("UnitOfMeasure");

                    b.HasKey("StockTransactionID");

                    b.HasIndex("OrderReceiptID");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Job", b =>
                {
                    b.Property<int>("job_id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Manager");

                    b.Property<bool?>("Retired");

                    b.Property<bool?>("Visible");

                    b.Property<int?>("company_id");

                    b.Property<string>("jobdesc");

                    b.Property<string>("jobname");

                    b.Property<int?>("jobnumber");

                    b.Property<int?>("leftNode");

                    b.Property<int?>("parent_id");

                    b.Property<int?>("project_id");

                    b.Property<int?>("rightnode");

                    b.Property<int?>("structurelevel");

                    b.HasKey("job_id");

                    b.ToTable("Job");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Manu", b =>
                {
                    b.Property<int>("ManuID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ManuCategoryID");

                    b.Property<string>("Manufacturer");

                    b.Property<string>("Phone");

                    b.Property<string>("WebAddress");

                    b.HasKey("ManuID");

                    b.ToTable("Manu");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.OrderReciept", b =>
                {
                    b.Property<int>("OrderReceiptID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeeID");

                    b.Property<int?>("OrderNum");

                    b.Property<DateTime?>("ReceiptDate");

                    b.HasKey("OrderReceiptID");

                    b.ToTable("OrderReciept");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Part", b =>
                {
                    b.Property<int>("PartID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddedBy");

                    b.Property<string>("CARBlevel");

                    b.Property<bool?>("CARBtrack");

                    b.Property<decimal?>("Cost");

                    b.Property<DateTime?>("DateAdded");

                    b.Property<int?>("FinishID");

                    b.Property<string>("ItemDescription");

                    b.Property<string>("ItemName");

                    b.Property<string>("Location");

                    b.Property<int?>("ManuID");

                    b.Property<string>("ManuPartNum");

                    b.Property<decimal?>("MarkUp");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<bool?>("ObsoluteFlag");

                    b.Property<string>("PartNum");

                    b.Property<int?>("PartTypeID");

                    b.Property<string>("SKU");

                    b.Property<string>("SupplierDescription");

                    b.Property<int?>("SupplierID");

                    b.Property<int?>("UID");

                    b.Property<string>("UOP");

                    b.Property<decimal?>("UOPCost");

                    b.Property<decimal?>("UnitToPurchaseFactor");

                    b.Property<bool?>("UseSupplierNameFlag");

                    b.Property<decimal?>("Waste");

                    b.Property<decimal?>("Weight");

                    b.HasKey("PartID");

                    b.HasIndex("PartTypeID");

                    b.HasIndex("SupplierID");

                    b.HasIndex("UID");

                    b.ToTable("Part");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.PartClass", b =>
                {
                    b.Property<int>("PartClassID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("PartClassID");

                    b.ToTable("PartClass");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.PartType", b =>
                {
                    b.Property<int>("PartTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Categoryid");

                    b.HasKey("PartTypeID");

                    b.HasIndex("Categoryid");

                    b.ToTable("PartType");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created");

                    b.Property<bool?>("IsContracted");

                    b.Property<bool?>("IsVisible");

                    b.Property<int?>("JobLinkID");

                    b.Property<int?>("ParentID");

                    b.Property<string>("ProjectName");

                    b.HasKey("ProjectID");

                    b.ToTable("Project");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.PurchaseLineItem", b =>
                {
                    b.Property<int>("LineID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("AmountReceived");

                    b.Property<int?>("ArticleID");

                    b.Property<string>("BCode");

                    b.Property<int?>("BomID");

                    b.Property<string>("Description");

                    b.Property<decimal?>("Extended");

                    b.Property<int?>("JobID");

                    b.Property<decimal?>("Length");

                    b.Property<string>("Note");

                    b.Property<int?>("OrderReceiptID");

                    b.Property<int?>("PartID");

                    b.Property<int?>("PurchaseOrderID");

                    b.Property<decimal?>("Qnty");

                    b.Property<bool?>("Recieved");

                    b.Property<string>("SupplierPartName");

                    b.Property<decimal?>("Thick");

                    b.Property<decimal?>("UnitCost");

                    b.Property<string>("UoP");

                    b.Property<decimal?>("UoPPrice");

                    b.Property<int?>("Uom");

                    b.Property<int?>("VendorID");

                    b.Property<decimal?>("Weight");

                    b.Property<decimal?>("Width");

                    b.HasKey("LineID");

                    b.HasIndex("PurchaseOrderID");

                    b.ToTable("PurchaseLineItem");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.PurchaseOrder", b =>
                {
                    b.Property<int>("OrderNum")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddedBy");

                    b.Property<DateTime?>("DateAdded");

                    b.Property<int?>("EmployeeID");

                    b.Property<DateTime?>("Expected_Date");

                    b.Property<bool?>("IsBackOrder");

                    b.Property<int?>("Job_id");

                    b.Property<string>("Memo");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<DateTime>("OrderDate");

                    b.Property<string>("OrderFormat");

                    b.Property<int?>("OrderState");

                    b.Property<decimal?>("OrderTotal");

                    b.Property<bool?>("Recieved");

                    b.Property<DateTime?>("RecievedDate");

                    b.Property<string>("SalesRep");

                    b.Property<int?>("ShipID");

                    b.Property<decimal?>("ShippingCost");

                    b.Property<decimal?>("SubTotal");

                    b.Property<int?>("SupplierID");

                    b.Property<bool?>("SuppressTax");

                    b.Property<decimal?>("Tax");

                    b.HasKey("OrderNum");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("Job_id");

                    b.HasIndex("SupplierID");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.ShipBy", b =>
                {
                    b.Property<int>("ShipID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShipByName");

                    b.HasKey("ShipID");

                    b.ToTable("ShipBy");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Supplier", b =>
                {
                    b.Property<int>("SupplierID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountNumber");

                    b.Property<int?>("AccountType");

                    b.Property<bool?>("Active");

                    b.Property<string>("Address1");

                    b.Property<string>("Address2");

                    b.Property<int?>("Category");

                    b.Property<string>("City");

                    b.Property<string>("Fax");

                    b.Property<string>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("SupplierName");

                    b.Property<string>("Zip");

                    b.HasKey("SupplierID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.TransActionType", b =>
                {
                    b.Property<int>("TransactionsTypeID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TransactionTypeName");

                    b.HasKey("TransactionsTypeID");

                    b.ToTable("TransActionType");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.UnitOfMeasure", b =>
                {
                    b.Property<int>("UID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("UOM");

                    b.HasKey("UID");

                    b.ToTable("UnitOfMeasure");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.UnitOfPurchase", b =>
                {
                    b.Property<int>("UoPID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PartID");

                    b.Property<int?>("UID");

                    b.Property<decimal?>("UOPCostUnit");

                    b.Property<string>("UOPName");

                    b.Property<decimal?>("UOPRatio");

                    b.HasKey("UoPID");

                    b.HasIndex("PartID");

                    b.ToTable("UnitOfPurchase");
                });

            modelBuilder.Entity("SubAssembly", b =>
                {
                    b.Property<int?>("SubAssemblyID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CPD_id");

                    b.Property<decimal?>("D");

                    b.Property<decimal?>("H");

                    b.Property<string>("MakeFile");

                    b.Property<int?>("ProductID");

                    b.Property<string>("SubAssemblyName");

                    b.Property<int?>("UnitID");

                    b.Property<decimal?>("W");

                    b.HasKey("SubAssemblyID");

                    b.HasIndex("ProductID");

                    b.ToTable("SubAssembly");
                });

            modelBuilder.Entity("Product", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Article", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Project", "Project")
                        .WithMany("Articles")
                        .HasForeignKey("ProjectID");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Attachment", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.PurchaseOrder", "PurchaseOrder")
                        .WithMany("Attachments")
                        .HasForeignKey("OrderNum");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Category", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.PartClass", "PartClass")
                        .WithMany("Categories")
                        .HasForeignKey("PartClassID");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.ClaimDocument", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.ClaimItem", "ClaimItem")
                        .WithMany("ClaimDocuments")
                        .HasForeignKey("ClaimItemID");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.ClaimItem", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Claim", "Claim")
                        .WithMany("ClaimItems")
                        .HasForeignKey("ClaimID");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.DocumentParts", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Document", "Document")
                        .WithMany("DocumentParts")
                        .HasForeignKey("DocID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Part", "Part")
                        .WithMany("DocumentParts")
                        .HasForeignKey("PartID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Inventory", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.OrderReciept", "OrderReciept")
                        .WithMany("Inventories")
                        .HasForeignKey("OrderReceiptID");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.Part", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.PartType", "PartType")
                        .WithMany("Parts")
                        .HasForeignKey("PartTypeID");

                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Supplier", "Supplier")
                        .WithMany("Parts")
                        .HasForeignKey("SupplierID");

                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.UnitOfMeasure", "UnitOfMeasure")
                        .WithMany("Parts")
                        .HasForeignKey("UID");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.PartType", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Category", "Category")
                        .WithMany("PartTypes")
                        .HasForeignKey("Categoryid");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.PurchaseLineItem", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.PurchaseOrder", "PurchaseOrder")
                        .WithMany("PurchaseLineItems")
                        .HasForeignKey("PurchaseOrderID");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.PurchaseOrder", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Employee", "Employee")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Job", "Job")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("Job_id");

                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Supplier", "Supplier")
                        .WithMany("PurchaseOrders")
                        .HasForeignKey("SupplierID");
                });

            modelBuilder.Entity("PurchaseSQLDB.DataAccess.EFClasses.UnitOfPurchase", b =>
                {
                    b.HasOne("PurchaseSQLDB.DataAccess.EFClasses.Part", "Part")
                        .WithMany("UnitOfPurchases")
                        .HasForeignKey("PartID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SubAssembly", b =>
                {
                    b.HasOne("Product", "Product")
                        .WithMany("SubAssemblies")
                        .HasForeignKey("ProductID");
                });
#pragma warning restore 612, 618
        }
    }
}