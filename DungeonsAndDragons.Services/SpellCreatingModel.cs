using DungeonsAndDragons.Domain;
using DungeonsAndDragons.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.Services
{
    public class SpellCreatingModel
    {
        public Dictionary<string, int>? CastingClassList { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Source = "Housebrew";
        public SpellType SpellType { get; set; }


        [Display(Name = "School")]
        public string MagicSchool { get; set; } = null!;


        [Display(Name = "Casting Time")]
        public string CastingTime { get; set; } = null!;
        public string Range { get; set; } = null!;
        public string Duration { get; set; } = null!;
        
        public int[] ClassIds { get; set; }
    }
}
