using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CodeRed.Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public decimal Price { get; set; }

        [DataMember]
        public List<string> Products { get; set; }

        [DataMember]
        public double Distance { get; set; }

        [DataMember]
        public string UserName { get; set; }
    }
}