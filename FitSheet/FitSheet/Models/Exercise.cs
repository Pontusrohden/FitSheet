using System;
using System.Collections.Generic;
using System.Text;

namespace FitSheet.Models
{
    class Exercise
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Reps { get; set; }
        public DateTime Date { get; set; }
        public double Pb { get; set; }
    }
}
