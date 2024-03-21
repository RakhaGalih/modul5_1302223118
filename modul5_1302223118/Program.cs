internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        penjumlahan.JumlahTigaAngka<int>(13,02,22); // 6 digit awal
        penjumlahan.JumlahTigaAngka<int>(22,31,18); // 6 digit akhir


    }
}

public class Penjumlahan
{
    public void JumlahTigaAngka<T>(T angka1, T angka2, T angka3)
    {
        dynamic NIM = angka1.ToString() + angka2.ToString() + angka3.ToString();
        Console.WriteLine(NIM);
    }
}
