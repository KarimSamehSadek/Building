using System.Drawing;

namespace Building
{
  class Program
  {
    public static void Main(string[] args)
    {
      Building mainBuilding = new Building("Hauptgebäude");

      Floor groundFloor = new Floor("EG");
      groundFloor.AddRoom(new Room("01", "Büroraum"));
      groundFloor.AddRoom(new Room("02", "Technikraum"));
      groundFloor.AddRoom(new MeetingRoom("03", "Meetingraum"));
      mainBuilding.AddFloor(groundFloor);

      Floor firstFloor = new Floor("1.OG");
      firstFloor.AddRoom(new GuestRoom("11", "Einzelzimmer", GuestRoomType.Single));
      firstFloor.AddRoom(new GuestRoom("12", "Doppelzimmer", GuestRoomType.Double));
      mainBuilding.AddFloor(firstFloor);

      mainBuilding.TurnOnAllFloorLights();


      Building hotel = new Building("Hotel");

      Console.WriteLine("#######################");

      Floor groundFloorHotel = new Floor("EG");
      for (int j = 0; j < 10; j++)
      {
        groundFloorHotel.AddRoom(new GuestRoom($"0{j}", $"Doppelzimmer0{j}", GuestRoomType.Double));
      }
      for (int j = 0; j < 5; j++)
      {
        groundFloorHotel.AddRoom(new GuestRoom($"0{j}", $"Einzelzimmer{j}", GuestRoomType.Single));
      }
      groundFloorHotel.AddRoom(new Room("0", "Technikraum"));

      hotel.AddFloor(groundFloorHotel);

      for (int i = 1; i < 5; i++)
      {
        Floor ithFloor = new Floor($"{i}.OG");

        for (int j = 0; j < 10; j++)
        {
          ithFloor.AddRoom(new GuestRoom($"{i}{j}", $"Doppelzimmer{i}{j}", GuestRoomType.Double));
        }

        for (int j = 5; j < 10; j++)
        {
          ithFloor.AddRoom(new GuestRoom($"{i}{j}", $"Einzelzimmer{i}{j}", GuestRoomType.Single));
        }

        ithFloor.AddRoom(new Room($"{i}", "Technikraum"));

        hotel.AddFloor(ithFloor);
      }

      hotel.TurnOnAllFloorLights();
    }
  }
}
