using Projet_employe.modele;
using Projet_employe.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_employe
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // créer le registre des employes
            RegistreEmploye listing = new RegistreEmploye();

            //créer un employe
            Employe emp1 = Utilitaire.CreerEmploye();
            Employe emp2 = Utilitaire.CreerEmploye();

            //ajoputer les employes dans le listing
            listing.AjouterEmploye(emp1);
            listing.AjouterEmploye(emp2);

            //Afficher le contenue de listing
            listing.ListerEmploye();
        }




    }




}
