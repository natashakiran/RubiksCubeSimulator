using System;
using System.Collections.Generic;
using RubikCubeSimulator.Enums;
using RubikCubeSimulator.Models;

namespace RubikCubeSimulator.Extensions
{
    public static class FaceExtensions
    {
        public static Queue<RotateCommand> GetCommands(this FaceNameEnum face, RotationDirectionEnum direction)
        {
            var commands = new Queue<RotateCommand>();

            switch (face)
            {
                case FaceNameEnum.Front when direction == RotationDirectionEnum.Clockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(2,0), new Position(2,1), new Position(2,2)
                            },
                            Next = FaceNameEnum.Right

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Right,
                            Positions = new List<Position>
                            {
                                new Position(0,0), new Position(1,0), new Position(2,0)
                            },
                            Next = FaceNameEnum.Down

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Down,
                            Positions = new List<Position>
                            {
                                new Position(0,2), new Position(0,1), new Position(0,0)
                            },
                            Next = FaceNameEnum.Left

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Left,
                            Positions = new List<Position>
                            {
                                new Position(2,2), new Position(1,2), new Position(0,2)
                            },
                            Next = FaceNameEnum.Up

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(2,0), new Position(2,1), new Position(2,2)
                            },
                            Next = null

                        });
                    break;
                case FaceNameEnum.Front when direction == RotationDirectionEnum.AntiClockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(2,2), new Position(2,1), new Position(2,0)
                            },
                            Next = FaceNameEnum.Left

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Left,
                            Positions = new List<Position>
                            {
                                new Position(0,2), new Position(1,2), new Position(2,2)
                            },
                            Next = FaceNameEnum.Down

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Down,
                            Positions = new List<Position>
                            {
                                new Position(0,0), new Position(0,1), new Position(0,2)
                            },
                            Next = FaceNameEnum.Right

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Right,
                            Positions = new List<Position>
                            {
                                new Position(2,0), new Position(1,0), new Position(0,0)
                            },
                            Next = FaceNameEnum.Up

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(2,2), new Position(2,1), new Position(2,0)
                            },
                            Next = null

                        });
                    break;

                case FaceNameEnum.Right when direction == RotationDirectionEnum.Clockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(1,2), new Position(2,2)
                            },
                            Next = FaceNameEnum.Bottom

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Bottom,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(1,0), new Position(0,0)
                            },
                            Next = FaceNameEnum.Down

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Down,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(1,2), new Position(2,2)
                            },
                            Next = FaceNameEnum.Front

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Front,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(1,2), new Position(2,2)
                            },
                            Next = FaceNameEnum.Up

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(1,2), new Position(2,2)
                            },
                            Next = null

                        });
                    break;
                case FaceNameEnum.Right when direction == RotationDirectionEnum.AntiClockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(1,2), new Position(0,2)
                            },
                            Next = FaceNameEnum.Front

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Front,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(1,2), new Position(0,2)
                            },
                            Next = FaceNameEnum.Down

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Down,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(1,2), new Position(0,2)
                            },
                            Next = FaceNameEnum.Bottom

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Bottom,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(1,0), new Position(2,0)
                            },
                            Next = FaceNameEnum.Up

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(1,2), new Position(0,2)
                            },
                            Next = null

                        });
                    break;

                case FaceNameEnum.Left when direction == RotationDirectionEnum.Clockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(1,0), new Position(2,0)
                            },
                            Next = FaceNameEnum.Front

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Front,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(1,0), new Position(2,0)
                            },
                            Next = FaceNameEnum.Down

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Down,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(1,0), new Position(2,0)
                            },
                            Next = FaceNameEnum.Bottom

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Bottom,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(1,2), new Position(0,2)
                            },
                            Next = FaceNameEnum.Up

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(1,0), new Position(2,0)
                            },
                            Next = null

                        });
                    break;
                case FaceNameEnum.Left when direction == RotationDirectionEnum.AntiClockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(1,0), new Position(0,0)
                            },
                            Next = FaceNameEnum.Bottom

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Bottom,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(1,2), new Position(2,2)
                            },
                            Next = FaceNameEnum.Down

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Down,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(1,0), new Position(0,0)
                            },
                            Next = FaceNameEnum.Front

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Front,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(1,0), new Position(0,0)
                            },
                            Next = FaceNameEnum.Up

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(1,0), new Position(0,0)
                            },
                            Next = null

                        });
                    break;

                case FaceNameEnum.Up when direction == RotationDirectionEnum.Clockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Left,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(0,1), new Position(0,2)
                            },
                            Next = FaceNameEnum.Bottom

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Bottom,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(0,1), new Position(0,2)
                            },
                            Next = FaceNameEnum.Right

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Right,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(0,1), new Position(0,2)
                            },
                            Next = FaceNameEnum.Front

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Front,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(0,1), new Position(0,2)
                            },
                            Next = FaceNameEnum.Left

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Left,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(0,1), new Position(0,2)
                            },
                            Next = null

                        });
                    break;
                case FaceNameEnum.Up when direction == RotationDirectionEnum.AntiClockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Left,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(0,1), new Position(0,0)
                            },
                            Next = FaceNameEnum.Front

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Front,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(0,1), new Position(0,0)
                            },
                            Next = FaceNameEnum.Right

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Right,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(0,1), new Position(0,0)
                            },
                            Next = FaceNameEnum.Bottom

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Bottom,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(0,1), new Position(0,0)
                            },
                            Next = FaceNameEnum.Left

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Left,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(0,1), new Position(0,0)
                            },
                            Next = null

                        });
                    break;
                
                case FaceNameEnum.Bottom when direction == RotationDirectionEnum.Clockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(0,1), new Position(0,2)
                            },
                            Next = FaceNameEnum.Left

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Left,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(1,0), new Position(0,0)
                            },
                            Next = FaceNameEnum.Down

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Down,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(2,1), new Position(2,0)
                            },
                            Next = FaceNameEnum.Right

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Right,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(1,2), new Position(2,2)
                            },
                            Next = FaceNameEnum.Up

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(0,1), new Position(0,2)
                            },
                            Next = null

                        });
                    break;
                case FaceNameEnum.Bottom when direction == RotationDirectionEnum.AntiClockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(0,1), new Position(0,0)
                            },
                            Next = FaceNameEnum.Right

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Right,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(1,2), new Position(0,2)
                            },
                            Next = FaceNameEnum.Down

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Down,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(2,1), new Position(2,2)
                            },
                            Next = FaceNameEnum.Left

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Left,
                            Positions = new List<Position>
                            {
                                new Position(0, 0), new Position(1,0), new Position(2,0)
                            },
                            Next = FaceNameEnum.Up

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Up,
                            Positions = new List<Position>
                            {
                                new Position(0, 2), new Position(0,1), new Position(0,0)
                            },
                            Next = null

                        });
                    break;

                case FaceNameEnum.Down when direction == RotationDirectionEnum.Clockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Front,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(2,1), new Position(2,2)
                            },
                            Next = FaceNameEnum.Right

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Right,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(2,1), new Position(2,2)
                            },
                            Next = FaceNameEnum.Bottom

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Bottom,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(2,1), new Position(2,2)
                            },
                            Next = FaceNameEnum.Left

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Left,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(2,1), new Position(2,2)
                            },
                            Next = FaceNameEnum.Front

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Front,
                            Positions = new List<Position>
                            {
                                new Position(2, 0), new Position(2,1), new Position(2,2)
                            },
                            Next = null

                        });
                    break;
                case FaceNameEnum.Down when direction == RotationDirectionEnum.AntiClockwise:
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Front,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(2,1), new Position(2,0)
                            },
                            Next = FaceNameEnum.Left

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Left,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(2,1), new Position(2,0)
                            },
                            Next = FaceNameEnum.Bottom

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Bottom,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(2,1), new Position(2,0)
                            },
                            Next = FaceNameEnum.Right

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Right,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(2,1), new Position(2,0)
                            },
                            Next = FaceNameEnum.Front

                        });
                    commands.Enqueue(
                        new RotateCommand()
                        {
                            FaceName = FaceNameEnum.Front,
                            Positions = new List<Position>
                            {
                                new Position(2, 2), new Position(2,1), new Position(2,0)
                            },
                            Next = null

                        });
                    break;

                default:
                    throw new ArgumentOutOfRangeException(nameof(face), face, null);
            }

            return commands;
        }
    }
}
