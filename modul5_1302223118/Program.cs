using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        SimpleDataBase<string> dataBase = new SimpleDataBase<string>();
        dataBase.AddNewData("13");
        dataBase.AddNewData("02");
        dataBase.AddNewData("22");
        dataBase.PrintAllData();
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