using System;
using System.Collections.Generic;

#nullable disable

namespace GorshokApi.Models
{
    public partial class Plant
    {
        public Plant()
        {
            CurrentPlants = new HashSet<CurrentPlant>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CurrentPlant> CurrentPlants { get; set; }
    }
}
