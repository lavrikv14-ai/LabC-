using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            var hospital = new Hospital();

            // Додавання лікарів
            var d1 = new Doctor(1, "Іваненко Олексій", "Терапевт");
            var d2 = new Doctor(2, "Петренко Марія", "Хірург");
            var d3 = new Doctor(3, "Сидоренко Олег", "Педіатр");
            hospital.AddDoctor(d1);
            hospital.AddDoctor(d2);
            hospital.AddDoctor(d3);

            // Реєстрація пацієнтів
            var p1 = new Patient(1, "Коваленко Тарас", 34);
            var p2 = new Patient(2, "Шевчук Анна", 27);
            var p3 = new Patient(3, "Мельник Ігор", 56);
            var p4 = new Patient(4, "Бондар Оксана", 42);
            hospital.RegisterPatient(p1);
            hospital.RegisterPatient(p2);
            hospital.RegisterPatient(p3);
            hospital.RegisterPatient(p4);

            // Створення палат
            var r101 = new HospitalRoom(101, 2);
            var r102 = new HospitalRoom(102, 1);
            var r201 = new HospitalRoom(201, 3);
            hospital.CreateRoom(r101);
            hospital.CreateRoom(r102);
            hospital.CreateRoom(r201);

            // Госпіталізація пацієнтів
            hospital.HospitalizePatient(1, 101);
            hospital.HospitalizePatient(2, 101);
            hospital.HospitalizePatient(3, 101); 
            hospital.HospitalizePatient(3, 102);
            hospital.HospitalizePatient(4, 201);

            // Додавання медичних записів
            var rec1 = new MedicalRecord(p1, d1, DateTime.Now.AddDays(-10), "ГРВІ, призначено лікування");
            var rec2 = new MedicalRecord(p2, d2, DateTime.Now.AddDays(-5), "Операція апендикса");
            var rec3 = new MedicalRecord(p1, d3, DateTime.Now.AddDays(-2), "Огляд після лікування");
            hospital.AddMedicalRecord(rec1);
            hospital.AddMedicalRecord(rec2);
            hospital.AddMedicalRecord(rec3);

            // Історія пацієнта
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА (ID=1) ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history)
            {
                Console.WriteLine($"Дата: {record.Date.ToShortDateString()}");
                Console.WriteLine($"Лікар: {record.Doctor.Name}");
                Console.WriteLine($"Опис: {record.Description}\n");
            }

            // Статистика
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}