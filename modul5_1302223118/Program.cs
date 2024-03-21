internal class Program
{
    private static void Main(string[] args)
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        Console.WriteLine(penjumlahan.JumlahTigaAngka<int>(13, 02, 22)); // 6 digit awal
        Console.WriteLine(penjumlahan.JumlahTigaAngka<int>(22, 31, 18)); // 6 digit akhir
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
