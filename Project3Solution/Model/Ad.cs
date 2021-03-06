﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum AdType {
        Other, All, Selling, Buying,

        [Display(Name = "Requesting a service")]
        ServiceRequest,

        [Display(Name = "Offering a service")]
        ServiceOffer,

        Event
    }

    public class Ad : Post
    {
        public Price Price { get; set; }
        public ISet<string> Categories { get; set; }
        public string Title { get; set; }
        public DateTime? ExpDate { get; set; }
        public int Views { get; set; }
        public Location Location { get; set; }
        public AdType Type { get; set; }
        public User ReservedBy { get; set; }
        public DateTime? EventDate { get; set; }
    }
}
