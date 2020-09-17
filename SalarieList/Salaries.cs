using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using SalarieDII;

namespace SalarieList
{
    public class Salaries : List<Salarie>
    {
        /// <summary>
        /// méthode qui ajoute un nouveau salarie
        /// mais vérifie si le salarie existe déjà dans la liste
        /// au niveau du numéro de métricule
        /// </summary>
        /// <param name="item">salarie à ajouter</param>
        public new void Add(Salarie item)
        {
            if (item != null && !this.Contains(item))
            {   // je peux l'ajouter
                base.Add(item);
            }

            /*
             if ( item != null )
             {
                 bool salExist = false;
                 foreach (Salarie sal in this)
                 {
                     if ( item.Equals(sal) )
                     {
                         salExist = true;
                     }
                 }
                 if ( !salExist )
                 {
                     base.Add(item);
                 }
             */
        }


        /// <summary>
        /// méthode qui va rechercher un salarié dans la liste à l'aide de n° matricule et
        /// le retourne
        /// </summary>
        /// <param name="mat">N° de matricule du salarié</param>
        /// <returns></returns>
        public Salarie Extract(string mat)
        {
            return this.Find(x => x.Matricule.Equals(mat));
        }

        /// <summary>
        /// supprime dans la liste 
        /// le salarié passé en argument
        /// </summary>
        /// <param name="item">object Salarie</param>
        /// <returns></returns>
        public new bool Remove(Salarie item)
        {
            return base.Remove(item);
        }

        /// <summary>
        /// supprime le salarié qui à pour matricule
        /// </summary>
        /// <param name="mat">matricule du salarié</param>
        /// <returns></returns>
        public bool Remove(string mat)
        {
            return base.Remove(this.Extract(mat));
        }

    }

    /// <summary>
    /// classe de gestion de salarie 
    /// avec Hashset
    /// </summary>
    public class SalarieHashSet : HashSet<Salarie> {
    
    }
}
