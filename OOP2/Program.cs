using System;

namespace OOP2
{

    class Program
    {
        static void Main(string[] args)
        {
            Individual individual = new Individual();
            individual.MusteriNo = "12345";
            individual.Name = "Çağrı"; 
            individual.Surname = "Çamyar";
            individual.TcNo = "1234512412";
            individual.Id = 1;

            Coorporate coorporate = new Coorporate();
            coorporate.Id = 2;
            coorporate.MusteriNo = "54321";
            coorporate.SirketAdi = "Kodlama.io";
            coorporate.VergiNo = "1234567890";

            Customer gercek = new Individual();
            Customer tuzel = new Coorporate();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add (individual);
            customerManager.Add (tuzel);
            customerManager.Add (gercek);


        }
    }

}