using System.Threading.Tasks;

namespace metot2
{
    internal class Hoca
    {
        string hders1 = "Algoritma";

        string hders2 = "Yazılım tasarımı";

        public void HocaDers()
        {
            Console.WriteLine("Dersleriniz:");
            Console.WriteLine(hders1);
            Console.WriteLine(hders2);
        }
    }

    internal class Ogrenci
    {
        string oders1 = "Matematik";

        string oders2 = "Algoritma";

        string oders3 = "Yazılım tasarımı";

        string oders4 = "Ofis yazılımları";

        public void OgrenciDers()
        {
            Console.WriteLine("Dersleriniz:");
            Console.WriteLine(oders1);
            Console.WriteLine(oders2);
            Console.WriteLine(oders3);
            Console.WriteLine(oders4);
        }

    }    internal class Sinif
    {
        string sders1 = "Salı:Algoritma";
        string sders2 = "Çarşamba:Matematik";
        string sders3 = "Perşembe:Ofis Yazılımları, Yazılım tasarımı";

        public void SinifDers()
        {
            Console.WriteLine("Sınıf Dersleri:");
            Console.WriteLine(sders1);
            Console.WriteLine(sders2);
            Console.WriteLine(sders3);
        }
    }

    internal class Program
    {

    static void Main(string[] args)
    {
        Hoca hoca = new Hoca();
        Ogrenci ogrenci = new Ogrenci();
        Sinif sinif = new Sinif();

        Console.WriteLine("Giriş yöntemini seçnizi:");
        Console.WriteLine("hoca//ogrenci//sinif");

        string giris = Console.ReadLine().ToLower();

        if (giris == "hoca")
        {
            hoca.HocaDers();
        }
        else if (giris == "ogrenci")
        {
            ogrenci.OgrenciDers();
        }
        else if (giris == "sinif")
        {
            sinif.SinifDers();
        }
        else
        {
            Console.WriteLine("Yanlıs yazdınız lütfen aşşağıdakilerden birini yazın:");
            Console.WriteLine("hoca//ogrenci//sinif");
        }
    

    }

    }

}
