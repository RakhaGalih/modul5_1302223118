using static System.Runtime.InteropServices.JavaScript.JSType;
internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        Console.WriteLine(penjumlahan.JumlahTigaAngka<int>(13, 02, 22)); // 6 digit awal
        Console.WriteLine(penjumlahan.JumlahTigaAngka<int>(22, 31, 18)); // 6 digit akhir

        SimpleDataBase<string> dataBase = new SimpleDataBase<string>();
        dataBase.AddNewData("13");
        dataBase.AddNewData("02");
        dataBase.AddNewData("22");
        dataBase.PrintAllData();
    }
}

public class Penjumlahan
{
    public T JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic bebas1 = angka1;
        dynamic bebas2 = angka2;
        dynamic bebas3 = angka3;
        return bebas1 + bebas2 + bebas3;
    }
}

public class SimpleDataBase<T>
{
    private List<T> storedData;
    List<DateTime> inputDates;
    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }
    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }
    public void PrintAllData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: ");

        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + i + " Berisi: " + storedData[i] + " yang disimpan pada waktu " + inputDates[i]);
        }
    }
}