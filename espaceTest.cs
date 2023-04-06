using espaceEmploye;
using espaceEntreprise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace espaceTest
{
    internal class espaceTest
    {
        static void Main(string[] args)
        {
            
                Employe e1 = new Employe ("koujjjj", "wafa");
                
                Employe e2 = new Employe("john", "Kham", 700, 2005);

            Employe e3 = new Employe("ahmed", "jouini",2000 , 1997,"sdf");
            Employe e4 = new Employe("rim", "dialo", 1500, 2000,"azerty");

            e1.Salaire = 5000;
            Console.WriteLine(e1);
            Console.WriteLine(e2);
            Console.WriteLine("courriel e3 {0} ",e3.Courriel);
            Console.WriteLine("courriel e4 {0} ", e4.Login);
            Console.WriteLine("salaire annuel e1 {0} ", e1.SalaireAnn());
            Console.WriteLine("Anciennete e1 {0} ", e1.Anciennete
                ());
            Console.ReadKey();
            e2.AugmentationSalaire();
            Console.WriteLine("Salaire Annuelle e2 {0}", e2.SalaireAnn());
            e3.AugmentationSalaire();

            Console.WriteLine("SalaireAnnuelle e3 {0}", e3.SalaireAnn());
           
        }
    }
}
