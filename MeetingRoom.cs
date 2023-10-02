using System;
namespace Building
{
  public class MeetingRoom : Room
  {
    public LightFunction AdditionalLight { get; set; }
    public BookingFunction Booking { get; set; }

    public MeetingRoom(string roomId, string roomName) : base(roomId, roomName)
    {
      this.Booking = new BookingFunction();
      this.AdditionalLight = new LightFunction();
    }

  }
}

