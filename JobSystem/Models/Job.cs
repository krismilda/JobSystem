using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobSystem.Models
{
    public class Job
    {
        public int ID { get; set; }
        public string Darbas { get; set; }
        public string Sritis { get; set; }
        public DateTime Darbo_pradzia { get; set; }
        public string Vieta { get; set; }
        public float Alga { get; set; }
        public int Trukme { get; set; }
    }
}