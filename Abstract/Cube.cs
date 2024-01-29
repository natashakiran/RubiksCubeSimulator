using System.Collections.Generic;
using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Abstract
{
    public abstract class Cube : ICube
    {
        public Dictionary<FaceNameEnum, IFace> Faces { get; } = new Dictionary<FaceNameEnum, IFace>();

        public abstract void CreateFaces();

        public IFace GetFace(FaceNameEnum name)
        {
            return Faces[name];
        }

        public void Reset()
        {
            foreach (var face in Faces)
            {
                face.Value.Reset();
            }
        }
        public void Print(FaceNameEnum faceName)
        {
            GetFace(faceName).Print();
        }

        public void Print()
        {
            foreach (var face in Faces)
            {
                Print(face.Key);
            }
        }
    }
}
