using ClassVsStruct.Codes.ClassCodes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct.Codes.ClassCodes.Methods
{
    public class MapPerson
    {
        public int MapPersonModel(ServiceModel[] model)
        {
            PersonelTable[] personelTable = new PersonelTable[model.Length];

            for (int i = 0; i < model.Length; i++)
            {
                personelTable[i] = new PersonelTable()
                {
                    Id = i,
                    Name = model[i].Personel.Name,
                    Surname = model[i].Personel.Surname,
                    Address = model[i].Personel.Address,
                };
            }

            return personelTable.Length;
        }
    }
}
