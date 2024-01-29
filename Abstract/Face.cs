using System;
using System.Collections.Generic;
using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Extensions;
using RubikCubeSimulator.Factories;
using RubikCubeSimulator.Interfaces;
using RubikCubeSimulator.Models;

namespace RubikCubeSimulator.Abstract
{
    public abstract class Face : IFace
    {
        private const int Size = 3;

        public const int Hops = 5;

        public Dictionary<FaceNameEnum, IFace> AdjacentFaces;

        public ICubicle Cubicle;

        private readonly ICubeFactory _cubeFactory;
        public FaceNameEnum FaceName;

        public ColorEnum ColorEnum;

        protected Face(ICubeFactory cubeFactory, ColorEnum color, FaceNameEnum name)
        {
            _cubeFactory = cubeFactory;
            FaceName = name;
            ColorEnum = color;
            Cubicle = cubeFactory.CreateCubeFactory(Size, color);
        }

        public void Reset()
        {
            Cubicle = _cubeFactory.CreateCubeFactory(Size, ColorEnum);
        }

        public void SetAdjacentFaces(Dictionary<FaceNameEnum, IFace> adjacentFaces)
        {
            AdjacentFaces = adjacentFaces;
        }

        public ICubicle GetCubicle()
        {
            return Cubicle;
        }

        public void RotateClockwise()
        {
            Cubicle.Transpose();
            Cubicle.ReverseRow();
            Rotate(FaceName.GetCommands(RotationDirectionEnum.Clockwise), Hops);
        }

        public void RotateAntiClockwise()
        {
            Cubicle.Transpose();
            Cubicle.ReverseColumn();
            Rotate(FaceName.GetCommands(RotationDirectionEnum.AntiClockwise), Hops);
        }

        public void Rotate(Queue<RotateCommand> commands, int hops)
        {
            var command = commands.Dequeue();
            var currentFace = AdjacentFaces[command.FaceName];

            if (command.Next == null) return;
            var nextFace = AdjacentFaces[command.Next.Value];
            nextFace.PropagateState(commands, hops - 1,
                currentFace.GetCubicle().GetValuesByPositions(command.Positions));
        }

        public void PropagateState(Queue<RotateCommand> commands, int hops,
            List<ICubeCell> sourceValues)
        {
            var command = commands.Dequeue();
            var currentState = Cubicle.GetValuesByPositions(command.Positions);
            Cubicle.ReplaceFaceState(sourceValues, command.Positions);

            if (command.Next == null) return;
            var nextFace = AdjacentFaces[command.Next.Value];
            nextFace.PropagateState(commands, hops - 1, currentState);
        }

        public void Print()
        {
            Console.WriteLine($"{FaceName}");
            Cubicle.Print();
        }
    }
}
