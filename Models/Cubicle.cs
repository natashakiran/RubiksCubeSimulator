using System;
using System.Collections.Generic;
using System.Linq;
using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Models
{
    public class Cubicle : ICubicle
    {
        public ICubeCell[,] Cubes { get; }
        private readonly int _size;

        public Cubicle(int size, ColorEnum color)
        {
            Cubes = new ICubeCell[size, size];
            _size = size;
            for (var row = 0; row < _size; row++)
            {
                for (var column = 0; column < _size; column++)
                {
                    Cubes[row, column] = new CubeCell(color, new Position(row, column));

                }
            }
        }

        public void ReverseColumn()
        {
            for (var column = 0; column < _size; column++)
            {
                for (var row = 0; row < _size / 2; row++)
                {
                    (Cubes[row, column], Cubes[_size - 1 - row, column]) = (Cubes[_size - 1 - row, column], Cubes[row, column]);
                }
            }
        }

        public void ReverseRow()
        {
            for (var row = 0; row < _size; row++)
            {
                for (var column = 0; column < _size / 2; column++)
                {
                    (Cubes[row, column], Cubes[row, _size - 1 - column]) = (Cubes[row, _size - 1 - column], Cubes[row, column]);
                }
            }

        }

        public void Transpose()
        {
            for (var row = 0; row < _size; row++)
            {
                for (var column = row + 1; column < _size; column++)
                {
                    (Cubes[row, column], Cubes[column, row]) = (Cubes[column, row], Cubes[row, column]);
                }
            }

        }

        public void ReplaceFaceState(List<ICubeCell> values, List<Position> positions)
        {
            var count = 0;
            
            foreach (var position in positions)
            {
                Cubes[position.Row, position.Column] = values[count];
                count++;
            }

        }

        public List<ICubeCell> GetValuesByPositions(List<Position> positions)
        {
            return positions.Select(position => Cubes[position.Row, position.Column]).ToList();
        }

        public void Print()
        {
            for (var row = 0; row < _size; row++)
            {
                for (var column = 0; column < _size; column++)
                {
                    Console.Write($" {Cubes[row, column].GetColor()}({row}:{column}) ");
                }
                Console.WriteLine();
            }
        }
    }

}
