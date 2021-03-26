using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;

namespace ExPetClinics
{
    public class CommandInterpreterer
    {
        private List<Pet> pets;
        private List<Clinic> clinics;

        public CommandInterpreterer()
        {
            pets = new List<Pet>();
            clinics = new List<Clinic>();
        }

        public IReadOnlyCollection<Pet> Pets
        {
            get { return pets.AsReadOnly(); }
        }

        public IReadOnlyCollection<Clinic> Clinics
        {
            get { return clinics.AsReadOnly(); }
        }

        public void CreatePet(string name, int age, string kind)
        {
            Pet pet = new Pet(name, age, kind);
            pets.Add(pet);
        }

        public void CreateClinic(string name, int rooms)
        {
            if (rooms % 2 == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            Clinic clinic = new Clinic(name, rooms);
            clinics.Add(clinic);
        }

        public bool Add(string petName, string clinicName)
        {

            Pet pet = pets.FirstOrDefault(x => x.Name == petName);
            if (pet == null)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            Clinic clinic = clinics.FirstOrDefault(x => x.Name == clinicName);
            if (clinic == null)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }
            int startRoom = ((clinic.PetClinck.Count - 1) / 2) + 1;
            int currentRoom = startRoom;
            for (int i = 1; i <= clinic.PetClinck.Count; i++)
            {
                if (clinic.PetClinck[currentRoom] == null)
                {
                    clinic.PetClinck[currentRoom] = pet;
                    return true;
                }

                if (i % 2 != 0)
                {
                    currentRoom = currentRoom - i;
                }
                else
                {
                    currentRoom = currentRoom + i;
                }
            }

            return false;
        }

        public bool Release(string clinicName)
        {
            if (clinics.FirstOrDefault(x => x.Name == clinicName).PetClinck.Any(x => x.Value != null))
            {
                Clinic clinic = clinics.FirstOrDefault(x => x.Name == clinicName);
                int startRoom = ((clinic.PetClinck.Count - 1) / 2) + 1;
                for (int i = startRoom; i <= clinic.PetClinck.Count; i++)
                {
                    if (clinic.PetClinck[i] != null)
                    {
                        clinic.PetClinck[i] = null;
                        return true;
                    }
                }
                for (int i = 1; i < startRoom; i++)
                {
                    if (clinic.PetClinck[i] != null)
                    {
                        clinic.PetClinck[i] = null;
                        return true;
                    }
                }
                return true;
            }
            return false;
        }

        public bool HasEmptyRooms(string clinicName)
        {
            if (clinics.FirstOrDefault(x => x.Name == clinicName).PetClinck.Any(x => x.Value == null))
            {
                return true;
            }
            return false;
        }

        public void Print(string clinicName)
        {
            foreach (var pet in clinics.FirstOrDefault(x => x.Name == clinicName).PetClinck.Values)
            {
                if (pet == null)
                {
                    Console.WriteLine("Room empty");
                }
                else
                {
                    Console.WriteLine($"{pet.Name} {pet.Age} {pet.Kind}");
                }
            }
        }

        public void Print(string clinicName, int room)
        {
            if (clinics.FirstOrDefault(x => x.Name == clinicName).PetClinck[room] == null)
            {
                Console.WriteLine("Room empty");
            }
            else
            {
                Pet pet = clinics.FirstOrDefault(x => x.Name == clinicName).PetClinck[room];
                Console.WriteLine($"{pet.Name} {pet.Age} {pet.Kind}");
            }
        }
    }
}
