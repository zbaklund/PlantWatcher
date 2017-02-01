﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ImagineCupBTrees.Models
{
    public class Device
    {
        public int Id { get; set; }
        [StringLength(500)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Description { get; set; }

        public virtual ICollection<DeviceReading> DeviceReadings { get; set; }
    }
}