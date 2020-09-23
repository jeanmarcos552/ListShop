using System.Runtime.Serialization;

namespace ListaShop.Model.Base
{
    [DataContract]
    public class BaseEntity
    {
        public long Id { get; set; }
    }
}
