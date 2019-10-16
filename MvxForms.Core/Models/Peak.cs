using System.Collections.Generic;

namespace MvxForms.Core.Models
{
    public class Peak
    {
        public string Name { get; set; }
        public string MountainRange { get; set; }
        public string Height { get; set; }
        public string Image { get; set; }
    }

    public class PeaksList
    {
        public List<Peak> Peaks { get; set; }
    }
}
