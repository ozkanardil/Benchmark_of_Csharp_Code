using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct.Codes.ClassCodes.Models
{
    public class PersonelTable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public AddressModel Address { get; set; }
    }
}
