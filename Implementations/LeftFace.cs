using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Factories;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Implementations
{
    public class LeftFace : Abstract.Face, ILeftFace
    {
        
        public LeftFace(ICubeFactory cubeFactory) : base(cubeFactory, ColorEnum.Mustard, FaceNameEnum.Left)
        {
        }

    }
}
