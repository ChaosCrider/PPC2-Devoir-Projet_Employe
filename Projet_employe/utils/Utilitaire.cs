﻿using Projet_employe.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_employe.utils
{
    internal class Utilitaire
    {
        internal static Employe CreerEmploye(string nom, string prenom, int age)
        {
            return new Employe(nom,prenom,age);
        }
    }
}
