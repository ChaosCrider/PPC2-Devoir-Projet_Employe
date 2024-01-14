using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Projet_employe.modele
{
    internal class Employe
    {

        private string _nom, _prenom;
        private int _age;

        public string Nom
        {
            set { _nom = value; }
            get { return _nom; }
        }
        public string Prenom
        {
            set { _prenom = value; }
            get { return _prenom; }
        }
        public int Age
        {
            set { _age = value; }
            get { return _age; } 
        }

        public Employe(string nom, string prenom, int age)
        {
            this._nom = nom;
            this._prenom = prenom;
            this._age = age;
        }
    }
}
