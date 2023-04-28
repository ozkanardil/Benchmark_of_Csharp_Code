// See https://aka.ms/new-console-template for more information
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using ClassVsStruct.Codes.ClassCodes.Methods;
using ClassVsStruct.Codes.StructCodes.Methods;

Console.WriteLine("Class vs Struct!");

var result = BenchmarkRunner.Run<ClassVsStructTest>();

//ClassVsStructTest test = new ClassVsStructTest();
//int resultClass = test.RunWithClass();
//int resultStruct = test.RunWithSruct();
//int result = resultClass + resultStruct;
//Console.WriteLine(String.Format("Sonuc: {0}", result));


[MemoryDiagnoser]
public class ClassVsStructTest
{

    [Benchmark]
    public int RunWithClass()
    {
        // 1) We populate the ServiceModel
        Service service = new Service();
        var serviceData = service.GetDataFromService();

        MapPerson mapPerson = new MapPerson();
        int personelCount = mapPerson.MapPersonModel(serviceData);

        MapAddress mapAddress = new MapAddress();
        int addressCount = mapAddress.MapAddressModel(serviceData);

        int recordCount = personelCount + addressCount;
        return recordCount;
    }

    [Benchmark(Baseline = true)]
    public int RunWithSruct()
    {
        // 1) We populate the ServiceModel
        ServiceS serviceS = new ServiceS();
        var serviceDataS = serviceS.GetDataFromService();

        MapPersonS mapPersonS = new MapPersonS();
        int personelCountS = mapPersonS.MapPersonModel(serviceDataS);

        MapAddressS mapAddressS = new MapAddressS();
        int addressCountS = mapAddressS.MapAddressModel(serviceDataS);

        int recordCountS = personelCountS + addressCountS;
        return recordCountS;
    }

}


