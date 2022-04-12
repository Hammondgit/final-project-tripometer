﻿using System.Collections.Generic;

namespace TripometerAPI.Models
{
    public class Owner
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
        public virtual string FullName
        {
            get
            {
                return FirstName + ' ' + LastName;
            }
        }
        public virtual List<Vehicle> Vehicles { get; set; }


        }
    }
