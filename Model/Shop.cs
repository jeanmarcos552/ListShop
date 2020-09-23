using System;
using System.ComponentModel.DataAnnotations.Schema;
using ListaShop.Model.Base;

namespace ListaShop.Model
{
    [Table("shopping")]
    public class Shop : BaseEntity
    {
        public bool Status { get; set; }

        public string Description { get; set; }

        public int Person { get; set; }

        public double Value { get; set; }


    }
}
