using ClassVsStruct.Codes.ClassCodes.Models;
using ClassVsStruct.Codes.StructCodes.Models;


namespace ClassVsStruct.Codes.StructCodes.Methods
{
    public struct MapPersonS
    {
        public int MapPersonModel(ServiceModelS[] model)
        {
            PersonelTableS[] personelTable = new PersonelTableS[model.Length];

            for (int i = 0; i < model.Length; i++)
            {
                personelTable[i] = new PersonelTableS()
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
