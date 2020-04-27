using System;
namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Dane os = new Dane();
            os.WyswietlDane();
            Console.ReadKey();
            
        }
    }
    public interface IDane
    {
        void WyswietlDane();
    }

    public class Dane : IDane
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        public Dane()
        {
            imie = "Jan";
            nazwisko = "Kowalski";
            wiek = 30;
        }

        public void WyswietlDane()
        {
            Console.WriteLine("Imie: {0}", imie);
            Console.WriteLine("Nazwisko: {0}", nazwisko);
            Console.WriteLine("Wiek: {0}", wiek);

        }
    }
}