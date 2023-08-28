using System;
using System.ComponentModel.DataAnnotations;

namespace JamServer.Application.DTOs
{
    public class AthleteDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage =" The Name is required")]
        public string Name { get; private set; }
        public DateTime Birthday { get; private set; }
    }
}
