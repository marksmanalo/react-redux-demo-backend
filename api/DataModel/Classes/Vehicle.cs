using System;
namespace DataModel.Classes
{
    public enum Color 
    {
        White,
        Black,
        Silver,
        Green
    }

    public class Vehicle
    {
        public int Id { get; set; }
        public int Miles { get; set; }
        public Color Color { get; set; }
        public string Model { get; set; }
    }
}
