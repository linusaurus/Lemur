using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using PurchaseSQLDB.DataAccess.EFClasses;

namespace PurchaseSQLDB.DataAccess.EFClasses
{
    public class PartType
    {
        public PartType()
        {
            this.Parts = new HashSet<Part>();
        }

        public int PartTypeID { get; set; }
        //public string PartType { get; set; }
        public int? Categoryid { get; set; }

        public Category Category { get; set; }
        public ICollection<Part> Parts { get; set; }
    }
}
