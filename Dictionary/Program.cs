using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new MyDictionary<int, string>();
            customer.Add(1, "Metin");
            customer.Add(2, "Doğa");
            customer.Add(3, "Kağan");
            customer.Add(4, "Özlem");
            customer.Add(5, "Kerem");

            Console.WriteLine("Müşteri sıra numarası giriniz! ");
            int No = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("Belirttiğiniz sıradaki müşterimiz: " + customer[No]);
            }
            catch
            {
                Console.WriteLine("Aradığınız kişiye şu anda ulaşılamıyor"); ;
            }
        }
    }
}
