using System;
using System.Linq.Expressions;

namespace Building
{
  public class Room
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public LightFunction LightingFunction { get; set; }

    public Room(string roomId, string roomName)
    {
      Id = roomId;
      Name = roomName;
      this.LightingFunction = new LightFunction();
    }
  }
}

