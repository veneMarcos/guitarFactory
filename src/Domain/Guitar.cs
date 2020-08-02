using System;

namespace  Domain
{
    public class Guitar
    {
        public Guid Id { get; set; }
        public Color GuitarColor { get; set; }
        public int StringQuantity { get; set; }

        public Model GuitarModel { get; set; }

        public static Guitar MakeGuitar(Color color, int stringQuantity, Model model)
        {
            return new Guitar()
            {
                Id = Guid.NewGuid(),
                GuitarColor = color,
                StringQuantity = stringQuantity,
                GuitarModel = model
            };
        }
    }

    public enum Color 
    {
        Green,
        Black,
        Red,
        Sunburst,
        White,
    }

    public enum Model
    {
        Stratocaster,
        LesPaul,
        Telecaster,
        Acoustic
    }
}