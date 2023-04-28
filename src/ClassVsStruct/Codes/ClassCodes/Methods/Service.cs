using ClassVsStruct.Codes.ClassCodes.Models;

namespace ClassVsStruct.Codes.ClassCodes.Methods
{
    public class Service
    {
        
        public ServiceModel[] GetDataFromService()
        {
            ServiceModel[] result = new ServiceModel[RecordCount.RecordCountNumber];

            for (int i = 0; i < RecordCount.RecordCountNumber; i++)
            {
                AddressModel address = new AddressModel();
                address.Street = i;
                address.Province = string.Format("Street-{0}", i);

                PersonelModel personel = new PersonelModel();
                personel.Id = i;
                personel.Name = string.Format("Name-{0}", i);
                personel.Surname = string.Format("Surname-{0}", i);
                personel.Address = address;

                ServiceModel serviceModel = new ServiceModel();
                serviceModel.Personel = personel;

                result[i] = serviceModel;
            }

            return result;
        }
    }
}
