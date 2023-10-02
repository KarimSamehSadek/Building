namespace Building
{
  public enum GuestRoomType
  {
    Single,
    Double
  }

  public class GuestRoom : Room
  {
    public GuestRoomType Type { get; set; }
    public BookingFunction Booking { get; set; }

    public GuestRoom(string roomId, string roomName, GuestRoomType type) : base(roomId, roomName)
    {
      this.Type = type;
      this.Booking = new BookingFunction();
    }
  }
}
