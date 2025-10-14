using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalManagementSystem
{
    public class Hospital
    {
        public List<Doctor> Doctors { get; set; }
        public List<Patient> Patients { get; set; }
        public List<HospitalRoom> Rooms { get; set; }
        public List<MedicalRecord> Records { get; set; }

        public Hospital()
        {
            Doctors = new List<Doctor>();
            Patients = new List<Patient>();
            Rooms = new List<HospitalRoom>();
            Records = new List<MedicalRecord>();
        }

        public void AddDoctor(Doctor doctor)
        {
            if (doctor == null) return;
            Doctors.Add(doctor);
        }

        public void RegisterPatient(Patient patient)
        {
            if (patient == null) return;
            Patients.Add(patient);
        }

        public void CreateRoom(HospitalRoom room)
        {
            if (room == null) return;
            Rooms.Add(room);
        }

        public void HospitalizePatient(int patientId, int roomNumber)
        {
            var patient = Patients.FirstOrDefault(p => p.Id == patientId);
            if (patient == null) return;

            var room = Rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
            if (room == null) return;

            room.AddPatient(patient);
        }

        public void AddMedicalRecord(MedicalRecord record)
        {
            if (record == null) return;
            Records.Add(record);
        }

        public List<MedicalRecord> GetPatientHistory(int patientId)
        {
            return Records.Where(r => r.Patient != null && r.Patient.Id == patientId).ToList();
        }

        public string GetStatistics()
        {
            int doctorsCount = Doctors.Count;
            int patientsCount = Patients.Count;
            int roomsCount = Rooms.Count;
            int patientsInRooms = Rooms.Sum(r => r.Patients?.Count ?? 0);

            var sb = new StringBuilder();
            sb.AppendLine("СТАТИСТИКА");
            sb.AppendLine($"Кількість лікарів: {doctorsCount}");
            sb.AppendLine($"Кількість зареєстрованих пацієнтів: {patientsCount}");
            sb.AppendLine($"Кількість палат: {roomsCount}");
            sb.AppendLine($"Кількість пацієнтів у палатах: {patientsInRooms}");
            return sb.ToString();
        }
    }
}
