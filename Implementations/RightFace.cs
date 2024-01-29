using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Factories;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Implementations
{
    public class RightFace : Abstract.Face, IRightFace
    {
        public RightFace(ICubeFactory cubeFactory) : base(cubeFactory, ColorEnum.Red, FaceNameEnum.Right)
        {
        }
    }
}
