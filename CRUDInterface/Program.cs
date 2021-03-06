using System;

namespace CRUDInterface
{
    class Program
    {
        void PrintMenu()
        {
            Console.WriteLine("Choose from option");
            Console.WriteLine("1. Add Doctors");
            Console.WriteLine("2. Print All Doctors");
            Console.WriteLine("3. Print one doctor");
            Console.WriteLine("4. Edit doctor speciality");
            Console.WriteLine("5. Edit doctor Experiance");
            Console.WriteLine("6. Delete doctor");
            Console.WriteLine("7. Sort and print");
            Console.WriteLine("8. Exit");
        }
        void InteractWithCustomers()
        {
            Clinic manage = new Clinic();
            int choice = 8;
            do
            {
                PrintMenu();
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid entry. Please try again");
                }
                switch (choice)
                {
                    case 1:
                        manage.Add5Doctors();
                        break;
                    case 2:
                        manage.PrintAllDoctors();
                        break;
                    case 3:
                        manage.PrintDoctorById();
                        break;
                    case 4:
                        manage.EditSpeciality();
                        break;
                    case 5:
                        manage.EditExperiance();
                        break;
                    case 6:
                        manage.DeleteDoctor();
                        break;

                    case 7:
                        manage.SortDoctorsByExperiance();
                        break;
                    case 8:
                        Console.WriteLine("Exiting... Bye...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again");
                        break;
                }
            } while (choice != 8);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.InteractWithCustomers();

        }

    }
}
