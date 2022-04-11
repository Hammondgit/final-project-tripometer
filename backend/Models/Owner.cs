﻿using System.Collections.Generic;

namespace TripometerAPI.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Vehicle> Vehicles { get; set; }

        }
    }
