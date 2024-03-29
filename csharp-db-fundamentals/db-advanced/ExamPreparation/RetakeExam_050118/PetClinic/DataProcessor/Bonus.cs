﻿namespace PetClinic.DataProcessor
{
    using System;
    using System.Linq;
    using PetClinic.Data;

    public class Bonus
    {
        public static string UpdateVetProfession(PetClinicContext context, string phoneNumber, string newProfession)
        {
            var vet = context.Vets.FirstOrDefault(x => x.PhoneNumber == phoneNumber);

            if (vet == null)
            {
                return $"Vet with phone number {phoneNumber} not found!";
            }
            else
            {
                string result = $"{vet.Name}'s profession updated from {vet.Profession} to {newProfession}.";
                vet.Profession = newProfession;
                context.SaveChanges();
                return result;
            }
        }
    }
}
