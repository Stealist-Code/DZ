using System.Collections.Generic;
using System;

namespace Hospitals
{
    public struct Hospital
    {
        public string Name;
        public List<string> TreatedDiseases;
        public int Capacity;
        public int CurrentPatients;
    }
}