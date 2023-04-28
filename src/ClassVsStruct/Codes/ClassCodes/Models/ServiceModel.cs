using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct.Codes.ClassCodes.Models
{
    public class ServiceModel
    {
        public PersonelModel Personel { get; set; }
    }

    public class PersonelModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public AddressModel Address { get; set; }
    }

    public class AddressModel
    {
        public int Street { get; set; }
        public string Province { get; set; }
    }

}
