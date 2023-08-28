using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
