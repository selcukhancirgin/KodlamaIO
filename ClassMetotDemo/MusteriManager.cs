using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void CustomerAdd(Musteri musteri)
        {
            Console.WriteLine(musteri.CustomerName + " " + musteri.CustomerSurname + " isimli müşteri eklendi.");
        }

        public void CustomerDelete(Musteri musteri)
        {
            Console.WriteLine(musteri.CustomerID + " numaralı " + musteri.CustomerName + " adlı müşteri silindi.");
        }

        public void CustomerList(Musteri musteri)
        {
            Console.WriteLine(musteri.CustomerID + ") " + musteri.CustomerName + " " + musteri.CustomerSurname);
        }
    }
}
