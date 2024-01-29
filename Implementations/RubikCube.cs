using RubikCubeSimulator.Abstract;
using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Implementations
{
    public class RubikCube : Cube, IRubikCube
    {
        private readonly IFrontFace _frontFace;
        private readonly IRightFace _rightFace;
        private readonly ILeftFace _leftFace;
        private readonly IBottomFace _bottomFace;
        private readonly IUpFace _upFace;
        private readonly IDownFace _downFace;

        public RubikCube(IFrontFace frontFace, IRightFace rightFace,
            ILeftFace leftFace, IBottomFace bottomFace, IUpFace upFace, IDownFace downFace)
        {
            _frontFace = frontFace;
            _rightFace = rightFace;
            _leftFace = leftFace;
            _bottomFace = bottomFace;
            _upFace = upFace;
            _downFace = downFace;
        }

        public override void CreateFaces()
        {
            Faces.Add(FaceNameEnum.Front, _frontFace);
            Faces.Add(FaceNameEnum.Right, _rightFace);
            Faces.Add(FaceNameEnum.Left, _leftFace);
            Faces.Add(FaceNameEnum.Up, _upFace);
            Faces.Add(FaceNameEnum.Down,_downFace);
            Faces.Add(FaceNameEnum.Bottom,_bottomFace);

            _frontFace.SetAdjacentFaces(Faces);
            _rightFace.SetAdjacentFaces(Faces);
            _leftFace.SetAdjacentFaces(Faces);
            _bottomFace.SetAdjacentFaces(Faces);
            _upFace.SetAdjacentFaces(Faces);
            _downFace.SetAdjacentFaces(Faces);
        }
    }
}
