﻿using JamServer.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Application.DTOs
{
    public class ClothesDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = " The Name is required")]
        public string Name { get; private set; }

        public string Description { get; private set; }

        public string Size { get; private set; }

        [DisplayName("Athlete")]
        public int AtlheteId { get; set; }
        public Athlete Athlete { get; set; }
    }
}
