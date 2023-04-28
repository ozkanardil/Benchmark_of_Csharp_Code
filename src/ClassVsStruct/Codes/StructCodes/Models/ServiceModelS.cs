using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct.Codes.StructCodes.Models
{
    public struct ServiceModelS
    {
        public PersonelModelS Personel { get; set; }
    }

    public struct PersonelModelS
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public AddressModelS Address { get; set; }
    }

    public struct AddressModelS
    {
        public int Street { get; set; }
        public string Province { get; set; }
    }

}
