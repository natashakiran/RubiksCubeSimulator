using System;
using System.Collections.Generic;
using System.Linq;
using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Interfaces;

namespace RubikCubeSimulator.Implementations
{
    public class RubikCubeHandler : IRubikCubeHandler
    {
        private readonly IRubikCube _rubikCube;
        private List<CommandEnum> _commandHistory;

        public RubikCubeHandler(IRubikCube rubikCube)
        {
            _rubikCube = rubikCube;
            _rubikCube.CreateFaces();
            _commandHistory = new List<CommandEnum>();
        }

        public void Execute(CommandEnum command)
        {
            _commandHistory.Add(command);

            switch (command)
            {
                case CommandEnum.F:
                    CommandHandler(RotationDirectionEnum.Clockwise, FaceNameEnum.Front);
                    break;
                case CommandEnum.Fa:
                    CommandHandler(RotationDirectionEnum.AntiClockwise, FaceNameEnum.Front);
                    break;
                case CommandEnum.R:
                    CommandHandler(RotationDirectionEnum.Clockwise, FaceNameEnum.Right);
                    break;
                case CommandEnum.Ra:
                    CommandHandler(RotationDirectionEnum.AntiClockwise, FaceNameEnum.Right);
                    break;
                case CommandEnum.U:
                    CommandHandler(RotationDirectionEnum.Clockwise, FaceNameEnum.Up);
                    break;
                case CommandEnum.Ua:
                    CommandHandler(RotationDirectionEnum.AntiClockwise, FaceNameEnum.Up);
                    break;
                case CommandEnum.B:
                    CommandHandler(RotationDirectionEnum.Clockwise, FaceNameEnum.Bottom);
                    break;
                case CommandEnum.Ba:
                    CommandHandler(RotationDirectionEnum.AntiClockwise, FaceNameEnum.Bottom);
                    break;
                case CommandEnum.L:
                    CommandHandler(RotationDirectionEnum.Clockwise, FaceNameEnum.Left);
                    break;
                case CommandEnum.La:
                    CommandHandler(RotationDirectionEnum.AntiClockwise, FaceNameEnum.Left);
                    break;
                case CommandEnum.D:
                    CommandHandler(RotationDirectionEnum.Clockwise, FaceNameEnum.Down);
                    break;
                case CommandEnum.Da:
                    CommandHandler(RotationDirectionEnum.AntiClockwise, FaceNameEnum.Down);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(command), command, null);
            }
        }

        public void Reset()
        {
            _commandHistory = new List<CommandEnum>();
            _rubikCube.Reset();
        }

        public void Print(FaceNameEnum faceName)
        {
            _rubikCube.Print(faceName);
            Console.WriteLine();
        }

        public void Print()
        {
            if (_commandHistory.Any())
                Console.WriteLine($" Executed Commands : {string.Join(" -> ", _commandHistory)}  \n\n");
            _rubikCube.Print();
            Console.WriteLine();
        }

        private void CommandHandler(RotationDirectionEnum rotationDirection, FaceNameEnum faceName)
        {
            switch (rotationDirection)
            {
                case RotationDirectionEnum.Clockwise:
                    _rubikCube.GetFace(faceName).RotateClockwise();
                    break;
                case RotationDirectionEnum.AntiClockwise:
                    _rubikCube.GetFace(faceName).RotateAntiClockwise();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(rotationDirection), rotationDirection, null);
            }
        }

    }
}
