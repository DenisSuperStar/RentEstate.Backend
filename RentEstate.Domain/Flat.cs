namespace RentEstate.Domain
{
    public class Flat : Estate
    {
        public string? Address { get; set; }
        public bool IsFlat { get; set; }
        public bool IsApartments { get; set; }
        public int CountRooms { get; set; }
        public bool IsPenthouse { get; set; }
        public bool IsElevator { get; set; }
        public int ElevatorsCount { get; set; }
        public int? TotalArea { get; set; }
        public int Floor { get; set; }
        public int FloorsInHouse { get; set; }
        public bool IsFurniture { get; set; }
        public bool HasWindowToYard { get; set; }
        public bool HasWindowToStreet { get; set; }
        public bool IsBalcony { get; set; }
        public bool IsLoggia { get; set; }
        public bool IsSeparatedBathroom { get; set; }
    }
}
