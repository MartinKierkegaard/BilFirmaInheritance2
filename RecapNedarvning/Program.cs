using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapNedarvning
{
    class Program
    {
        private static void Main(string[] args)
        {

            //var dieselBilListe = new List<Dieselbil>();

            //dieselBilListe.Add(new Dieselbil(5000,2014, 20, 30));
            //dieselBilListe.Add(new Dieselbil(15000, 2015, 28, 40));
            //dieselBilListe.Add(new Dieselbil(280000, 2015, 17, 50));
            //dieselBilListe.Add(new Dieselbil(35000, 2016, 12,70, false));
            //dieselBilListe.Add(new Dieselbil(81400, 2012, 17,60, false));

            //var benzinBilListe = new List<BenzinBil>();
            //benzinBilListe.Add(new BenzinBil(30000, 2016, 15, 40));
            //benzinBilListe.Add(new BenzinBil(150000, 2014, 17,30));
            //benzinBilListe.Add(new BenzinBil(39000, 2015, 12, 80));
            //benzinBilListe.Add(new BenzinBil(400000, 2016, 11, 50));
            //benzinBilListe.Add(new BenzinBil(120000, 2016, 48, 25));

            //var elBilListe = new List<ElBil>();
            //elBilListe.Add(new ElBil(200000, 2015, 10, 50));
            //elBilListe.Add(new ElBil(200000, 2015, 13, 50));
            //elBilListe.Add(new ElBil(200000, 2015, 9, 30));
            //elBilListe.Add(new ElBil(200000, 2016, 12, 30));
            //elBilListe.Add(new ElBil(200000, 2016, 16, 20));

            var bilListe = new List<Bil>();
            bilListe.Add(new Dieselbil(5000, 2014, 20, 30));
            bilListe.Add(new Dieselbil(15000, 2015, 28, 40));
            bilListe.Add(new Dieselbil(280000, 2015, 17, 50));
            bilListe.Add(new Dieselbil(35000, 2016, 12, 70, false));
            bilListe.Add(new Dieselbil(81400, 2012, 17, 60, false));

            bilListe.Add(new BenzinBil(30000, 2016, 15, 40));
            bilListe.Add(new BenzinBil(150000, 2014, 17, 30));
            bilListe.Add(new BenzinBil(39000, 2015, 12, 80));
            bilListe.Add(new BenzinBil(400000, 2016, 11, 50));
            bilListe.Add(new BenzinBil(120000, 2016, 48, 25));

            bilListe.Add(new ElBil(200000, 2015, 10, 50));
            bilListe.Add(new ElBil(200000, 2015, 13, 50));
            bilListe.Add(new ElBil(200000, 2015, 9, 30));
            bilListe.Add(new ElBil(200000, 2016, 12, 30));
            bilListe.Add(new ElBil(200000, 2016, 16, 20));

            //Biler med fejldata i
            bilListe.Add(new Dieselbil(0, 2012, 17, 60, false));
            bilListe.Add(new Dieselbil(-80000, 2012, 17, 60, false));


            Bil ElBilEx = new ElBil(200000, 2016, 16, 20);
            ElBilEx.RegNr = "AR 23456";

            Dieselbil bilEx;

            try
            {
                try
                {
                    bilEx = (Dieselbil) ElBilEx; //as Dieselbil;

                }
                catch (InvalidCastException e)
                {
                    //Console.WriteLine("Der er en fejl !!!");
                    throw new InvalidCastException("Invalid cast exception for bil med regnr:  " + ElBilEx.RegNr);
                }
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {

            }

            Console.ReadLine();


            ////Console.WriteLine("grønafgift er : " + bilEx.GrønAfgift());

            Bil b1 = new Dieselbil(5000, 2014, 20, 30);
            
            Console.WriteLine("grøn afgift før cast : " + b1.GrønAfgift());
            var dieselbil = b1 as Dieselbil;

            Console.WriteLine("grøn afgift efter cast " + dieselbil.GrønAfgift());


            Console.ReadLine();

            //    if (b1 is Dieselbil)
            //    {
            //        Console.WriteLine("grøn afgift før cast : " + b1.GrønAfgift());
            //    }
            //    var dieselbil = b1 as Dieselbil;


            //    //Console.WriteLine("har bilen partikelfilter: " + dieselbil.PartikelFilter);

            //    Console.WriteLine("grøn afgift efter cast " + dieselbil.GrønAfgift());

            //}



            int tæller =0;

            foreach (var bil in bilListe)
            {
                tæller++;
                Console.WriteLine("Bil nr : " + tæller);
                if (bil is Dieselbil)
                {
                    

                    var dBil = bil as Dieselbil;

                    
                    Console.WriteLine("Det er en dieselbil");
                    Console.WriteLine("Har partikelfilter: " + dBil.PartikelFilter);
                }

                if (bil is BenzinBil)
                {
                    var bBil = bil as BenzinBil;
                    Console.WriteLine("Det er en benzinbil");
                    Console.WriteLine("Bilens tank er : " + bBil.Tank);

                }

                if (bil is ElBil)
                {
                    var eBil = bil as ElBil;
                    Console.WriteLine("Det er en elbil");
                    Console.WriteLine("Batterikapaciteten er : " + eBil.BatteriKapacitet);
                }

                if (bil is IElMotor)
                {
                    var elMotor = bil as IElMotor;
                    Console.WriteLine("Bilen har Elmotor");
                    Console.WriteLine("Ladetiden er : " + elMotor.LadeTid());
                }

                Console.WriteLine("Rækkevidden er : "+ bil.RækkeVidde());
                try
                {
                    Console.WriteLine("Registreringsafgift : " + bil.Registreringsafgift());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Registreringsafgiften har en fejl :" + e.Message);
                }

                Console.WriteLine("Grønafgift: " + bil.GrønAfgift());
                Console.WriteLine("--------------");

            }

            //foreach (Bil b in dieselBilListe)
            //{
            //    if (b is Dieselbil)
            //    {
            //        Console.WriteLine("grøn afgift før cast : " + b.GrønAfgift());
            //        var dieselbil = b as Dieselbil;


            //        //Console.WriteLine("har bilen partikelfilter: " + dieselbil.PartikelFilter);

            //        Console.WriteLine("grøn afgift efter cast " + dieselbil.GrønAfgift());
            //    }


            //    if (b is IDieselbil)
            //    {
            //        //var bil = b as Dieselbil;
            //        var bil = b as IDieselbil;

            //        Console.WriteLine("Det er en dieselbil");
            //    }
            //}

            Console.ReadLine();
        }
    }
}
