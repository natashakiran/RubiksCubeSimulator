using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Factories;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Implementations
{
    public class DownFace : Abstract.Face, IDownFace
    {
        public DownFace(ICubeFactory cubeFactory) : base(cubeFactory, ColorEnum.Yellow, FaceNameEnum.Down)
        {
        }
    }
}
