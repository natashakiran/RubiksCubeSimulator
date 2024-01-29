using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Factories;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Implementations
{
    public class BottomFace : Abstract.Face, IBottomFace
    {

        public BottomFace(ICubeFactory cubeFactory) : base(cubeFactory, ColorEnum.Blue, FaceNameEnum.Bottom)
        {
        }
    }
}
