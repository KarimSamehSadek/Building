using System;
namespace Building
{
  public class BookingFunction
  {
    public bool IsBooked { get; set; }

    public BookingFunction()
    {
      this.IsBooked = false;
    }
    public void BookRoom()
    {
      this.IsBooked = true;
    }
  }
}

