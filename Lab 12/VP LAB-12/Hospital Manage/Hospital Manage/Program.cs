using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Manage
{
    

    class Program
    {
        // Simulated "Database"
        static List<Doctor> Doctors = new List<Doctor>
    {
        new Doctor { dID = 1, Name = "Dr. Smith", Designation = "Cardiologist", Specialization = "Heart" },
        new Doctor { dID = 2, Name = "Dr. Brown", Designation = "Dermatologist", Specialization = "Skin" }
    };

        static List<Patient> Patients = new List<Patient>
    {
        new Patient { pID = 1, Name = "John Doe", Address = "123 Main St", ContactNo = "123-456-7890" },
        new Patient { pID = 2, Name = "Jane Roe", Address = "456 Elm St", ContactNo = "987-654-3210" }
    };

        static List<Appointment> Appointments = new List<Appointment>
    {
        new Appointment { aID = 1, pID = 1, dID = 1, AppointmentDate = DateTime.Now, AppointmentTime = TimeSpan.FromHours(10) },
        new Appointment { aID = 2, pID = 2, dID = 2, AppointmentDate = DateTime.Now.AddDays(1), AppointmentTime = TimeSpan.FromHours(11.5) }
    };

        static void Main(string[] args)
        {
            // Query 1: Using Joins
            Console.WriteLine("Query 1: Using Joins");
            var joinQuery = from appointment in Appointments
                            join patient in Patients on appointment.pID equals patient.pID
                            join doctor in Doctors on appointment.dID equals doctor.dID
                            select new
                            {
                                AppointmentID = appointment.aID,
                                PatientName = patient.Name,
                                DoctorName = doctor.Name,
                                AppointmentDate = appointment.AppointmentDate.ToShortDateString(),
                                AppointmentTime = appointment.AppointmentTime
                            };

            foreach (var item in joinQuery)
            {
                Console.WriteLine($"Appointment ID: {item.AppointmentID}, Patient: {item.PatientName}, Doctor: {item.DoctorName}, Date: {item.AppointmentDate}, Time: {item.AppointmentTime}");
            }

            Console.WriteLine("\n---------------------------------\n");

            // Query 2: Using Navigation Properties
            Console.WriteLine("Query 2: Using Navigation Properties");
            // Simulate Navigation Properties (manual relationship setup for demonstration)
            foreach (var appointment in Appointments)
            {
                appointment.Patient = Patients.FirstOrDefault(p => p.pID == appointment.pID);
                appointment.Doctor = Doctors.FirstOrDefault(d => d.dID == appointment.dID);
            }

            var navigationQuery = from appointment in Appointments
                                  select new
                                  {
                                      AppointmentID = appointment.aID,
                                      PatientName = appointment.Patient.Name,
                                      DoctorName = appointment.Doctor.Name,
                                      AppointmentDate = appointment.AppointmentDate.ToShortDateString(),
                                      AppointmentTime = appointment.AppointmentTime
                                  };

            foreach (var item in navigationQuery)
            {
                Console.WriteLine($"Appointment ID: {item.AppointmentID}, Patient: {item.PatientName}, Doctor: {item.DoctorName}, Date: {item.AppointmentDate}, Time: {item.AppointmentTime}");
            }
        }

        // Entities (Classes for Tables)
        public class Doctor
        {
            public int dID { get; set; }
            public string Name { get; set; }
            public string Designation { get; set; }
            public string Specialization { get; set; }
        }

        public class Patient
        {
            public int pID { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string ContactNo { get; set; }
        }

        public class Appointment
        {
            public int aID { get; set; }
            public int pID { get; set; }
            public int dID { get; set; }
            public DateTime AppointmentDate { get; set; }
            public TimeSpan AppointmentTime { get; set; }

            // Navigation Properties
            public Patient Patient { get; set; }
            public Doctor Doctor { get; set; }
        }
    }

}
