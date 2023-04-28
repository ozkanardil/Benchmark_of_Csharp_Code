using ClassVsStruct.Codes.ClassCodes.Models;
using ClassVsStruct.Codes.StructCodes.Models;


namespace ClassVsStruct.Codes.StructCodes.Methods
{
    public struct MapAddressS
    {
        public int MapAddressModel(ServiceModelS[] model)
        {
            AdrressTableS[] adrressTable = new AdrressTableS[model.Length];

            for (int i = 0; i < model.Length; i++)
            {
                adrressTable[i] = new AdrressTableS()
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
