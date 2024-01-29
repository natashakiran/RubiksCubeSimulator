using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Factories
{
    public interface ICubeFactory
    {
        ICubicle CreateCubeFactory(int size, ColorEnum color);
    }
}
