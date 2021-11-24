using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MC
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> doctorsSpeciality = new List<string>() { "Aesthetic", "Cardiology", "Endocrinology", "Gynecology", "Neurology",
            "Neonatology", "Oncology", "Ophtalmology", "Otolaringology", "Proctology", "Traumatology"};

            Random rnd = new Random();
            StaffRepository staffRepository = new StaffRepository();
            staffRepository.Add(new Worker("Alex", 21));
            staffRepository.Add(new Nurse("Anna", 25));
            //staffRepository.Add(new Doctor("John", 30, "Traumatology"));

            string name = "John";
            int age = default(int);
            for (int i = 0; i < doctorsSpeciality.Count; i++)
            {
                age = rnd.Next(25, 55);
                staffRepository.Add(new Doctor(name + i, age, doctorsSpeciality[i]));
                Console.WriteLine($"Doctor name: {name + i}, age: {age}, speciality: {doctorsSpeciality[i]}");
            }


            //BaseRepository<Doctor> doctors = new BaseRepository<Doctor>();
            //doctors.Add()
            //doctors.GetAll();

            //string speciality = "Cardiology";

            DoctorRepository doctorRepository = new DoctorRepository();
            Staff doctor = new Doctor();
            doctorRepository.Add(doctor);

            PatientRepository patientRepository = new PatientRepository();
            patientRepository.Add(new Patient("Henry", 65, "Cardiology"));

            doctorRepository.AssignSpeciality(doctorsSpeciality[5]);
            
            
            staffRepository.PaySalary();

            Console.ReadKey();
        }
    }


}

