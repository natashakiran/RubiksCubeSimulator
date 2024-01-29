using System.ComponentModel;

namespace RubikCubeSimulator.Enums
{
    public enum CommandEnum
    {
        [Description("F")]
        F,
        [Description("F'")]
        Fa,
        [Description("R")]
        R,
        [Description("R'")]
        Ra,
        [Description("U")]
        U,
        [Description("U'")]
        Ua,
        [Description("B")]
        B,
        [Description("B'")]
        Ba,
        [Description("L")]
        L,
        [Description("L'")]
        La,
        [Description("D")]
        D,
        [Description("D'")]
        Da,
    }
}
