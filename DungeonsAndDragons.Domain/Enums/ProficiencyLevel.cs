using System.ComponentModel.DataAnnotations;

namespace DungeonsAndDragons.Domain
{
    public enum ProficiencyLevel
    {
        Normal,
        [Display(Name="Jack of All Trades")]
        JackOfAllTrades,
        Proficiency,
        Expertise
    }
}