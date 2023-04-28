using ClassVsStruct.Codes.ClassCodes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStruct.Codes.ClassCodes.Methods
{
    public class MapAddress
    {
        public int MapAddressModel(ServiceModel[] model)
        {
            AdrressTable[] adrressTable = new AdrressTable[model.Length];

            for (int i = 0; i < model.Length; i++)
            {
                adrressTable[i] = new AdrressTable()
                {
                    PersonelId = i,
                    Street = model[i].Personel.Address.Street,
                    Province = model[i].Personel.Address.Province
                };
            }

            return adrressTable.Length;
        }
    }
}
