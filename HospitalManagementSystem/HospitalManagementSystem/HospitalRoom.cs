using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalRoom
    {
        public int RoomNumber { get; set; }
        public int Capacity { get; set; }
        public List<Patient> Patients { get; set; }

        public HospitalRoom(int roomNumber, int capacity)
        {
            RoomNumber = roomNumber;
            Capacity = capacity;
            Patients = new List<Patient>();
        }

        public void AddPatient(Patient patient)
        {
            if (patient == null) return;

            if (Capacity <= 0)
                return;

            if (Patients.Count >= Capacity)
            {
                Console.WriteLine($"Палата {RoomNumber} переповнена");
                return;
            }

            Patients.Add(patient);
        }
    }
}