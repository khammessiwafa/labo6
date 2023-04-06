using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace espaceEmploye
{
    class Employe
    {

        private static int employeCree;
        private int code;

        public int Code
        {
            get => code;

        }

        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value.ToUpper(); }

        }
        private string prenom;
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value.ToLower(); }

        }
        private double salaire;

        public double Salaire
        {
            get { return salaire; }
            set
            { if (value > 1000) salaire = value;
                else salaire = 1000;
            }

        }

        private int anneeEmbauche;

        public int AnneeEmbauche
        {
            get { return anneeEmbauche; }
            set
            {
                if (value > 1970) anneeEmbauche = value;
                else anneeEmbauche = 1970;
            }


        }
        private string courriel;

        public string Courriel
        {
            get { return courriel; }


        }

        private string login;

        public string Login
        {
            get { return login; }


        }

        private string motPasse;

        public string MotPasse
        {
            get { return motPasse; }
            set
            {
                if (value.Length >= 6) motPasse = value;
                else motPasse = "ABC963ABC";
            }
        }
        public Employe(string nom, string prenom)
        { Nom = nom;
            Prenom = prenom;
            Salaire = 0;
            AnneeEmbauche = 1970;
            MotPasse = "";
            CreerLogin();
            CreerEmail();
            code = ++employeCree;

        }
        public Employe(string nom, string prenom, double salaire,
            int anneeEmbauche)
        {
            Nom = nom;
            Prenom = prenom;
            Salaire = 0;
            AnneeEmbauche = 1970;
            MotPasse = "";
            CreerLogin();
            CreerEmail();
            code = ++employeCree;

        }
        public Employe(string nom, string prenom, double salaire,
            int anneeEmbauche, string motPasse)
        {
            Nom = nom;
            Prenom = prenom;
            Salaire = 0;
            AnneeEmbauche = 1970;
            MotPasse = "";
            CreerLogin();
            CreerEmail();
            code = ++employeCree;

        }

        private void CreerLogin()
        {
            login = Nom.Substring(0, 2) + "." + Prenom.Substring(0, 4);
        }
        private void CreerEmail()
        {
            courriel = Prenom + "." + Nom.Substring(0, 1) + "proIT.ca";
        }

        public double SalaireAnn()
        {
            double salaireAnn = 12 * Salaire;
            return salaireAnn;
        }
        public int Anciennete()
        {

            return 2021 - AnneeEmbauche;
        }
        public void AugmentationSalaire()

        {
            int anciennete = Anciennete();
            if (anciennete < 3)
            {
                Salaire = Salaire * 1.05;
            }
            else if (anciennete < 7 && anciennete >= 3)
            {
                Salaire = Salaire * 1.1;
            }
            else if (anciennete < 15 && anciennete >= 7)
            {
                Salaire = Salaire * 1.15;
            }
            else if (anciennete >= 15)
            {
                Salaire = Salaire * 1.2;
            }


        }
        public void AugmentationSalaire(double pourcentage)
        {
            Salaire = Salaire * (1 + (pourcentage / 100));
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("Code : " + Code));
            sb.AppendLine("Nom: " + Nom + "" + Prenom);
            sb.AppendLine("Année d'embauche: " + AnneeEmbauche);
            sb.AppendLine("Courriel: " + Courriel);
            sb.AppendLine("Login: " + Login);
            sb.AppendLine("Salaire: " + Salaire);

            return sb.ToString();

        }

        public bool Egalite(Employe autre)
        {
            return autre.Code == this.code && autre.Nom.Equals(this.Nom); 
        }
        public static bool operator == (Employe premierEmploye, Employe deuxiemeEmploye)
        {
            return premierEmploye.Egalite(deuxiemeEmploye);
        }
        public static bool operator !=(Employe premierEmploye, Employe deuxiemeEmploye)
        {
            return premierEmploye.Egalite(deuxiemeEmploye);
        }
        public static bool operator >(Employe premierEmploye, Employe deuxiemeEmploye)
        {
            return premierEmploye.Anciennete()> deuxiemeEmploye.Anciennete();
        }
        public static bool operator <(Employe premierEmploye, Employe deuxiemeEmploye)
        {
            return premierEmploye.Anciennete() < deuxiemeEmploye.Anciennete();
        }

        static void Main2(string[] args)
        {

            Employe premierEmploye = new Employe("koukou", "teoerff");
            premierEmploye.AnneeEmbauche = 1650;
            premierEmploye.Salaire = 200;
            premierEmploye.MotPasse = "00";
            Console.WriteLine(premierEmploye);
            Employe deuxiemeEmploye = new Employe("Jonathan", "Kande", 700, 2005);
            Console.WriteLine(deuxiemeEmploye);

            Console.WriteLine("Premier employé est-il le même que le deuxième ? {0}", premierEmploye == deuxiemeEmploye);

            Console.WriteLine("Premier employé est-il hiérarchiquement supérieur au deuxième ? {0}", premierEmploye > deuxiemeEmploye);

            Console.ReadKey();
        }



    }

  
   
}

