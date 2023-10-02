using System.Collections.Generic;
namespace Building
{

  public class Floor
  {
    public String FloorName { get; set; }
    public List<Room> Rooms { get; set; }

    public Floor(String floorName)
    {
      FloorName = floorName;
      Rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
      this.Rooms.Add(room);
    }

    public List<Room> GetRooms()
    {
      return Rooms;
    }

    public void SwitchOnAllRoomLights()
    {
      foreach (Room r in this.Rooms)
      {
        r.LightingFunction.TurnOnLight();
      }
    }
  }
}