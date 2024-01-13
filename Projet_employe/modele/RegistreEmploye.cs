using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_employe.modele
{
    internal class RegistreEmploye
    {
        private List<Employe> employeList;

        public RegistreEmploye() 
        {
                this.employeList = new List<Employe>();
        }

        internal void AjouterEmploye(Employe emp)
        {
            employeList.Add(emp);
        }

        internal void ListerEmploye()
        {
            foreach(Employe tmp in employeList) 
            {
                Console.WriteLine(tmp);
            }
        }
    }
}
