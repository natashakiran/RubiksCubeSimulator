using RubikCubeSimulator.Enums;

namespace RubikCubeSimulator.Interfaces
{
    public interface ICube
    {
        void CreateFaces();
        IFace GetFace(FaceNameEnum name);
        void Reset();
        void Print(FaceNameEnum faceName);
        void Print();
    }
}
