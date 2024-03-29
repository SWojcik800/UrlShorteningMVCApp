﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UrlShortenerMVCApp.Models
{
    public class Address
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Url]
        public string Url { get; set; }

        public string ApplicationUserId { get; set; }

        public ApplicationUser User { get; set; }
    }

   
}
