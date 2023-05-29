using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.Domain
{
    public enum SpellType
    {
        Cantrip,
        [Display(Name="1st-level")]
        FirstLevel,
        [Display(Name="2nd-level")]
        SecondLevel,
        [Display(Name="3rd-level")]
        ThirdLevel,
        [Display(Name="4th-level")]
        FourthLevel,
        [Display(Name="5th-level")]
        FifthLevel,
        [Display(Name="6th-level")]
        SixthLevel,
        [Display(Name="7th-level")]
        SeventhLevel,
        [Display(Name="8th-level")]
        EighthLevel,
        [Display(Name="9th-level")]
        NinthLevel
    }
}
