using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ExPetClinics
{
   public class Clinic
   {
       private Dictionary<int, Pet> petClinick;
 

       public Clinic(string name, int rooms)
        {
            Name = name;
            PetClinck = new Dictionary<int, Pet>();
            for (int i = 1; i <= rooms; i++)
            {
                PetClinck.Add(i,null);
            }
        }

       public string Name { get; set; }

       public Dictionary<int,Pet> PetClinck { get; set; }


   }
}
