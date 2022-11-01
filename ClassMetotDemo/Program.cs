using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {  
            Musteri musteri = new Musteri();

            musteri.CustomerID = 1;
            musteri.CustomerName = "Selçukhan";
            musteri.CustomerSurname = "Çirgin";

            MusteriManager musteriManager = new MusteriManager();

            //Listeleme
            Console.WriteLine("Listeleme\n");
            musteriManager.CustomerList(musteri);

            Console.WriteLine("\n\n");
            //Silme
            Console.WriteLine("Silme\n");
            musteriManager.CustomerDelete(musteri);

            Console.WriteLine("\n\n");
            //Ekleme
            Console.WriteLine("Ekleme\n");
            musteriManager.CustomerAdd(musteri);


            Console.ReadKey();
        }
    }
}
