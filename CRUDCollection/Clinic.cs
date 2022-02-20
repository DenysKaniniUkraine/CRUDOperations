using ModelsLabrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDCollection
{
    internal class Clinic
    {
        private List<Doctor> doctors;

        public Clinic()
        {
            doctors = new List<Doctor>();
        }

        public void AddDoctor()
        {
            Doctor doctor = new Doctor();
            int id = 101 + doctors.Count();
            doctor.Id = id;
            doctor.DoctorDeatilsFromConsole();
            if (doctor != null)
            { doctors.Add(doctor); }
        }

        public Doctor GetDoctorById(int id)
        {
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[0] != null)
                {
                    if (doctors[i].Id == id)
                        return doctors[i];
                }
            }
            Console.WriteLine("We don't have such doctor :-(");
            return null;
        }

        public void PrintDoctor(Doctor doctor)
        {
            Console.WriteLine(new string('*', 80));
            doctor.Print();
            Console.WriteLine(new string('*', 80));
        }

        public void PrintDoctorById()
        {
            int id = TakeDoctorIdFromUser();
            for (int i = 0; i < doctors.Count; i++)
            {
                if (doctors[i].Id == id)
                { doctors[i].Print(); }
            }
        }
        private int TakeDoctorIdFromUser()
        {
            int id = 0;
            Console.WriteLine("Please Enter doctor's Id: ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry fore id. Please try again");
            }

            return id;
        }
        public void PrintAllDoctors()
        {
            foreach (var item in doctors)
            {
                PrintDoctor(item);
            }
        }

        public void EditSpeciality()
        {
            Doctor doctor = GetDoctorById(TakeDoctorIdFromUser());
            if (doctor != null)
            {
                Console.WriteLine("The doctors details are: ");
                PrintDoctor(doctor);
                Console.WriteLine($"Pleaase enter new specality for doctor {doctor.Name}");
                string speciality = Console.ReadLine();
                doctor.Speciality = speciality;
                Console.WriteLine("speciality edited...");
                Console.WriteLine("Edited doctor data");
                PrintDoctor(doctor);
            }
        }
        public void EditExperiance()
        {
            Doctor doctor = GetDoctorById(TakeDoctorIdFromUser());
            if (doctor != null)
            {
                Console.WriteLine("The doctors details are: ");
                PrintDoctor(doctor);
                float experiance = 0f;
                Console.WriteLine($"Enter doctor's {doctor.Name} experiance int {doctor.Speciality}: ");
                while (!float.TryParse(Console.ReadLine(), out experiance))
                {
                    Console.WriteLine("Invalide entry for exeriance, try again...");
                }

                doctor.Experiance = experiance;
                Console.WriteLine("experiance edited...");
                Console.WriteLine("Edited doctor data");
                PrintDoctor(doctor);
            }
        }

        public void DeleteDoctor()
        {
            int id = TakeDoctorIdFromUser();
            Doctor doctor = GetDoctorById(id);
            doctors.Remove(doctor);
        }
        internal void SortDoctorsBySpeciality()
        {
            doctors.Sort();
            PrintAllDoctors();
        }
    }
}
