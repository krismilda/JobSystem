using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobSystem.Models
{
    public class Job
    {
        public int Id { get; set; }
        public string Work { get; set; }
        public string Field{ get; set; }
        public DateTime Start { get; set; }
        public string Locality { get; set; }
        public float  salary { get; set; }
        public string duration { get; set; }
    }
}