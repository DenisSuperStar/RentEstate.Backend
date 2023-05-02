namespace RentEstate.Domain
{
    public class Room : Flat
    {
        public bool IsRampant { get; set; }
        public bool IsGarbageChute { get; set; }
        public string? Parking { get; set; }
    }
}
