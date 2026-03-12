using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment1
{
    internal class Patient
    {
        public int PatientId;
        public string PatientName;
        public int Age;
        public string Disease;

        public void PatientDetails()
        {
            Console.WriteLine($"Patient Id: {PatientId}");
            Console.WriteLine($"Patient Name: {PatientName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Disease: {Disease}");
        }
    }
}
