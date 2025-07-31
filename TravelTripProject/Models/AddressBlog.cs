﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models
{
    public class AddressBlog
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string FullAddress { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Location { get; set; } // e.g., Google Maps embed link
    }
}