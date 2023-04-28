using ClassVsStruct.Codes.ClassCodes.Models;
using ClassVsStruct.Codes.StructCodes.Models;

namespace ClassVsStruct.Codes.StructCodes.Methods
{
    public struct ServiceS
    {
        public ServiceModelS[] GetDataFromService()
        {
            ServiceModelS[] result = new ServiceModelS[RecordCount.RecordCountNumber];

            for (int i = 0; i < RecordCount.RecordCountNumber; i++)
            {
                AddressModelS addressS = new AddressModelS();
                addressS.Street = i;
                addressS.Province = string.Format("Street-{0}", i);

                PersonelModelS personelS = new PersonelModelS();
                personelS.Id = i;
                personelS.Name = string.Format("Name-{0}", i);
                personelS.Surname = string.Format("Surname-{0}", i);
                personelS.Address = addressS;

                ServiceModelS serviceModelS = new ServiceModelS();
                serviceModelS.Personel = personelS;

                result[i] = serviceModelS;
            }

            return result;
        }
    }
}
