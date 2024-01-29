using System.Collections.Generic;
using RubikCubeSimulator.Enums;

namespace RubikCubeSimulator.Models
{
    public class RotateCommand
    {
        public List<Position> Positions { get; set; }
        public FaceNameEnum FaceName { get; set; }
        public FaceNameEnum? Next { get; set; }
    }
}
