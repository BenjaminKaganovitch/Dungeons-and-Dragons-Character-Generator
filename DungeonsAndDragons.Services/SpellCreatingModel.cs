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
        public IEnumerable<Class>? CastingClassList { get; set; }
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
        
        public List<string> Classes { get; set; }

        public bool verbal { get; set; }
        public bool somatic { get; set; }
        public bool material { get; set; }
        public string materials { get; set; }
    }
}
