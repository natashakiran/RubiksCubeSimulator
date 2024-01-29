using RubikCubeSimulator.Enums;

namespace RubikCubeSimulator.Interfaces
{
    public interface ICubeCell
    {
        ColorEnum GetColor();
        void Print();
    }
}
