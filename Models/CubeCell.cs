using System;
using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Models
{
    public class CubeCell : ICubeCell
    {
        public CubeCell(ColorEnum color, Position position)
        {
            Color = color;
            Position = position;
        }

        public ColorEnum Color { get; set; }

        public Position Position { get; set; }

        public ColorEnum GetColor()
        {
            return Color;
        }

        public void Print()
        {
            Console.Write($" {Position.Row}:{Position.Column}({Color}) ");
        }
    }

}
