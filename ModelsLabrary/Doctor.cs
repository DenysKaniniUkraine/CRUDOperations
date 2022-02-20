using System;

namespace ModelsLabrary
{
    public class Doctor : IComparable<Doctor>

    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Experiance { get; set; }
        public string Speciality { get; set; }


        public void Print()
        {
            Console.WriteLine($"\n ID{Id} Doctor {Name} have {Experiance} years of experiance in {Speciality}");
        }

        public void DoctorDeatilsFromConsole()
        {

            Console.WriteLine("Enter doctor's name: ");
            Name = Console.ReadLine();

            Console.WriteLine($"Enter doctor's {Name} specialisation: ");
            Speciality = Console.ReadLine();

            float experiance = 0f;
            Console.WriteLine($"Enter doctor's {Name} experiance in {Speciality}: ");
            while (!float.TryParse(Console.ReadLine(), out experiance))
            {
                Console.WriteLine("Invalide entry for exeriance, try again...");
            }

            Experiance = experiance;
        }

        public int CompareTo(Doctor other)
        {
            return this.Experiance.CompareTo(other.Experiance);
        }
    }
}
