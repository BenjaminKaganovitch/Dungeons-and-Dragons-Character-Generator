namespace DungeonsAndDragons.Domain
{
    //The values are 1 higher than the number of sides so that Random.Next(1, DieType.[insert type here]) works for getting the intended values.
    public enum DieType
    {
        SixSides = 7,
        EightSides = 9,
        TenSides = 11,
        TwelveSides = 13
    }
}