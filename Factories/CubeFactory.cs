using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Interfaces;
using RubikCubeSimulator.Models;

namespace RubikCubeSimulator.Factories
{
    public class CubeFactory : ICubeFactory
    {
        public ICubicle CreateCubeFactory(int size, ColorEnum color)
        {
            return new Cubicle(size, color);
        }
    }
}
