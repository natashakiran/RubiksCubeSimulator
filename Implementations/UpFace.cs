using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Factories;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Implementations
{
    public class UpFace : Abstract.Face, IUpFace
    {
        public UpFace(ICubeFactory cubeFactory) : base(cubeFactory, ColorEnum.White, FaceNameEnum.Up)
        {
        }

    }
}
