using System;

namespace CloudyShop.Models.EF
{
    public abstract class CommonAbstract
    {
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}