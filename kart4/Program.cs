using System;
using System.Data.Entity;

namespace kart4
{
    public class Samochod
    {
        public int id { get; set; }

        public string marka { get; set; }

    }

    public class SalonSamochodowy : DbContext
    {
        public DbSet<Samochod> Samochods { get; set; }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            using (var Salon = new SalonSamochodowy() )
            {
                //var S = new Samochod() { marka = "Renault"};
                //Salon.Samochods.Add(S);
                //Salon.SaveChanges();

                foreach (var ss in Salon.Samochods)
                {
                    Console.WriteLine($"Marka samochodu: {ss.marka} ");
                }
                 

            }

        }
    }
}
