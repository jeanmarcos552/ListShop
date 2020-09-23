using System;
using ListaShop.Model.Base;

namespace ListaShop.Model
{
    public class Person : BaseEntity
    {
        
        public string FirstName { set; get; }

        public string LastName { set; get; }

        public string Email { set; get; }

        public string PassWord { set; get; }

        //public virtual ICollection<ListaShop> ListaShop { get; set; }

    }
}
