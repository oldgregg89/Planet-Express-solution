using System;
using System.Collections.Generic;

namespace PlanetExpress.Models
{
  public class Parcel
  {
    public string Desciption { get; set; }
    public int Weight { get; set; }
    public int Height { get; set; }
    public int Length { get; set; }
    public int Width { get; set; }
    private int _volume;
    private decimal _cost;

    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel(string description, int weight, int height, int length, int width)
    {
      Desciption = desciption;
      Weight = weight;
      Height = height;
      Length = length;
      Width = width;
      _volume = SetVolume();
      _cost = SetCost();
      _instances.Add(this);
    }
    private int SetVolume()
    {
      return (Height * Length * Width);
    }

    public int GetVolume()
    {
      return _volume;
    }
    private decimal SetCost()
    {
      if (Weight < 10)
      {
        return 5;
      }
      else if (Weight >= 10 && Weight < 20)
      {
        return 10;
      }
      else
      {
        return 10000;
      }
    }
    public decimal GetCost()
    {
      return _cost;
    }

    public List<Parcel> GetAll()
    {
      return _instances;
    }
  }
}