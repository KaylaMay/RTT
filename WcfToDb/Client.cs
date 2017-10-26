using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfToDb
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int Cust_id { get; set; }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Surname { get; set; }
        [DataMember]
        public string Gender { get; set; }
        [DataMember]
        public string Residential_Address { get; set; }
        [DataMember]
        public string Work_Address { get; set; }
        [DataMember]
        public string Postal_Address { get; set; }
        [DataMember]
        public string Cell_nr { get; set; }
        [DataMember]
        public string Work_nr { get; set; }


    }
}
