using System.Collections.Generic;
using RubikCubeSimulator.Models;

namespace RubikCubeSimulator.Interfaces
{
    public interface ICubicle
    {
        void ReverseColumn();
        void ReverseRow();
        void Transpose();
        void ReplaceFaceState(List<ICubeCell> values, List<Position> positions);
        List<ICubeCell> GetValuesByPositions(List<Position> positions);
        void Print();
    }

}
