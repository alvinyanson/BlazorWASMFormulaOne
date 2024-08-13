using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaOne.Shared.Models
{
    public class Driver
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string RacingNb { get; set; } = string.Empty;

        [Required]
        public string Team { get; set; } = string.Empty;    

    }
}
