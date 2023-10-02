using System.Collections.Generic;
namespace Building
{

  public class Building
  {
    public string Name { get; set; }
    public List<Floor> Floors { get; set; }

    public Building(string name)
    {
      Name = name;
      Floors = new List<Floor>();
    }

    public void AddFloor(Floor floor)
    {
      this.Floors.Add(floor);
    }

    public void TurnOnAllFloorLights()
    {
      foreach (Floor f in this.Floors)
      {
        f.SwitchOnAllRoomLights();
      }
    }
  }
}