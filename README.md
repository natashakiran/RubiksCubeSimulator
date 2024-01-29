Rubik's Cube Simulator

This program simulates a Rubik's Cube and provides commands to manipulate it. It represents the cube using different colored faces and allows users to perform rotations using predefined commands.

Faces and Colors
Front Face: Red
Right Face: Blue
Left Face: Green
Back Face: Mustard
Up Face: White
Down Face: Yellow

Commands
The following commands can be used to manipulate the Rubik's Cube:

F - Rotate the Front face clockwise.
Fa - Rotate the Front face counterclockwise.
R - Rotate the Right face clockwise.
Ra - Rotate the Right face counterclockwise.
U - Rotate the Up face clockwise.
Ua - Rotate the Up face counterclockwise.
B - Rotate the Back face clockwise.
Ba - Rotate the Back face counterclockwise.
L - Rotate the Left face clockwise.
La - Rotate the Left face counterclockwise.
D - Rotate the Down face clockwise.
Da - Rotate the Down face counterclockwise.

Usage
To execute commands, use the rubikCubeHandler.Execute() method, followed by the desired command from the CommandEnum.

Example usage:
rubikCubeHandler.Execute(CommandEnum.F);
rubikCubeHandler.Execute(CommandEnum.Ra);
rubikCubeHandler.Execute(CommandEnum.U);
rubikCubeHandler.Execute(CommandEnum.Ba);
rubikCubeHandler.Execute(CommandEnum.L);
rubikCubeHandler.Execute(CommandEnum.Da);
rubikCubeHandler.Print();

Resetting
To reset the Rubik's Cube to its initial state, use the following:

Console.WriteLine("Resetting");
rubikCubeHandler.Reset();
rubikCubeHandler.Print();

This will reset the Rubik's Cube to its original configuration and print it to the console.

Feel free to explore and experiment with different commands to solve the Rubik's 