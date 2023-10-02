using System;
namespace Building
{
  public class LightFunction
  {
    public bool IsLightOn { get; set; }

    public LightFunction()
    {
      this.IsLightOn = false;
    }

    public void TurnOnLight()
    {
      this.IsLightOn = true;
      System.Console.WriteLine("Licht ist eingeschaltet");
    }

    public void TurnOffLight()
    {
      this.IsLightOn = false;
      System.Console.WriteLine("Licht ist ausgeschaltet");
    }

  } 
}

