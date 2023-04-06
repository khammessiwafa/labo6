using espaceEmploye;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace espaceEntreprise
{
    internal class Entreprise
    {
        private string nom;

        public string Nom
        { 
            get { return nom; }
            set { nom = value; }
        }
        private List<Employe> listeEmployes;
        public Entreprise(string nom)
        {
            
                Nom = nom;
            listeEmployes = new List<Employe>();  
        }
        public void AddEmploye(Employe employe) 
        {
            listeEmployes.Add(employe);
        }
        public void AddEmploye(string nom, string prenom)
        {
           Employe nouvelEmploye= new Employe (nom, prenom);
            AddEmploye(nouvelEmploye);
        }
        public void AddEmploye(string nom, string prenom, double salaire, int anneeEmbauche)
        {
            Employe nouvelEmploye = new Employe(nom, prenom, salaire, anneeEmbauche);
            AddEmploye(nouvelEmploye);
        }
        public void AddEmploye(string nom, string prenom, double salaire, int anneeEmbauche, string motPasse)
        {
            Employe nouvelEmploye = new Employe(nom, prenom, salaire, anneeEmbauche, motPasse);
            AddEmploye(nouvelEmploye);
        }
        public Employe FindEmploye (int code) 
        { foreach (Employe employe in listeEmployes)
                if (employe.Code == code) { return employe; }
            return null;    
        }
        public Employe FindEmploye(string nom, string prenom )
        {
            foreach (Employe employe in listeEmployes)
                if (employe.Nom.Equals(nom)&& employe.Prenom.Equals(prenom)) { return employe; }
            return null;
        }
        /// <returns>Vrai si employé supprimé sinon faux</returns>
        public bool DelEmploye (int code)
        {
            Employe EmployeAsupprimer = FindEmploye(code);
            listeEmployes.Remove(EmployeAsupprimer);
            return true;
            if (EmployeAsupprimer is null) 
            { return false; }   

        }
        public bool DelEmploye(string nom, string prenom)
        {
            Employe employeAsupprimer = FindEmploye(nom, prenom);
            listeEmployes.Remove(employeAsupprimer);
            return true;
            if (employeAsupprimer is null)
            { return false; }

        }
        public double SalaireMensuel()
        {
            double sommeSalairemensuel = 0;

            foreach (Employe employe in listeEmployes) 
            {
                sommeSalairemensuel += employe.Salaire;
            }
            return sommeSalairemensuel;
        }
        public double AugmentationSalaire()
        {
            

            foreach (Employe employe in listeEmployes)
            {
                employe.AugmentationSalaire(15);
            }
            return SalaireMensuel();
        }
        public double ChargeTotale()
        {
            
            return SalaireMensuel() * 12;
        }

        public override string ToString()
        {
           StringBuilder strB= new StringBuilder();
            strB.AppendLine(string.Format("Entreprise :{0}", nom));
            strB.AppendLine("ChargeTotale :" +ChargeTotale());
            strB.AppendLine("---------------liste des employés-------------" );
            foreach (Employe employe in listeEmployes)
            {
                strB.AppendLine(employe.ToString());
                strB.AppendLine("---------------");
            }
            return strB.ToString();



        }
        public static void Main2(string[] args)
        {
            Entreprise entreprise = new Entreprise("LaCité");
            entreprise.AddEmploye("Joel", "Muteba");
            entreprise.AddEmploye("Jonathan", "Kande", 7000, 2015);
            Console.WriteLine(entreprise);
            entreprise.AugmentationSalaire();
           
            Console.WriteLine(entreprise);
            
            entreprise.DelEmploye(0);
            Console.WriteLine(entreprise);
           
        }






    }
}
