using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Factories;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Implementations
{
    public class FrontFace : Abstract.Face, IFrontFace
    {
        public FrontFace(ICubeFactory cubeFactory) : base(cubeFactory, ColorEnum.Green, FaceNameEnum.Front)
        {
        }
    }
}
