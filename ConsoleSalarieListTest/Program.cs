using SalarieDII;
using SalarieList;
using System;
using System.Diagnostics;

namespace ConsoleSalarieListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ///----------------------///
                /*
                Debug.WriteLine("Test de la liste de salarié");
                Salarie sal = new Salarie("loulou", "louf", "15JLK45");
                Salarie sal1 = new Salarie("loula", "lou", "15JLK45");
                Salarie sal2 = new Salarie("louli", "lou", "17JLK45");

                Salaries listeSal = new Salaries();
                listeSal.Add(sal);
                listeSal.Add(sal2);

                Debug.WriteLine($"Ajout de loulou true affichage: {listeSal[0].ToString()}");
                Debug.WriteLine($"Ajout de loula faux donc voir louli : {listeSal[1].ToString()}");
                //Debug.WriteLine($"Ajout impossible : {listeSal[2].ToString()}");

                Debug.WriteLine($"Recherche un matricule vide et on l'affiche: {listeSal.Extract("")} ");
                Debug.WriteLine($"Recherche du matricule et on l'affiche: {listeSal.Extract("17JLK45")} ");
                Debug.WriteLine($"Recherche du matricule inexistant: {listeSal.Extract("17JL455")}");

                Debug.WriteLine($"on supprime le salarié passé en argument true: {listeSal.Remove(sal)} ");
                Debug.WriteLine($"on supprime le salarié qui a pour matricule: {listeSal.Remove("17JLK45")} ");
                Debug.WriteLine($"Nombre d'occurence dans la liste 0 == {listeSal.Count}");
                ////////////////////////
                */

                //// Mise en palce du conteneur HashSet
                SalarieHashSet hashSal = new SalarieHashSet();
                Salarie sal = new Salarie("loulou", "louf", "15JLK45");
                Salarie sal1 = new Salarie("loula", "lou", "15JLK45");
                Salarie sal2 = new Salarie("louli", "lou", "17JLK45");

                Debug.WriteLine($"le premier salarié loulou a bien été ajouté true:{hashSal.Add(sal)}");
                Debug.WriteLine($"le deuxieme salarié loula ne doit pas être ajouté false:{hashSal.Add(sal1)}");
                Debug.WriteLine($"le troisième salarié louli a bien été ajouté true:{hashSal.Add(sal2)}");

                foreach (Salarie item in hashSal)
                {
                    Debug.WriteLine(item.ToString());
                }
                
            }
            catch ( Exception e  )
            {
                Console.WriteLine(e.Message);
            }
            

        }
    }
}
