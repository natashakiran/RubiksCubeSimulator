using RubikCubeSimulator.Enums;

namespace RubikCubeSimulator.Interfaces
{
    public interface IRubikCubeHandler
    {
        void Execute(CommandEnum command);
        void Reset();
        void Print(FaceNameEnum faceName);
        void Print();
    }
}
