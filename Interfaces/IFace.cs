using System.Collections.Generic;
using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Models;

namespace RubikCubeSimulator.Interfaces
{
    public interface IFace
    {
        ICubicle GetCubicle();

        void SetAdjacentFaces(Dictionary<FaceNameEnum, IFace> adjacentFaces);

        void RotateClockwise();

        void RotateAntiClockwise();

        void Rotate(Queue<RotateCommand> commands, int hops);

        void PropagateState(Queue<RotateCommand> commands, int hops,
            List<ICubeCell> sourceValues);

        void Reset();

        void Print();

    }
}
