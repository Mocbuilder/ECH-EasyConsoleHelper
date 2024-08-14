# EasyConsoleHelper - ECH

EasyConsoleHelper includes some simple QoL-Functions to help with creating console applications. Currently there are two functions, more will be added later.

## Functions

### ECH.ColorPrint()
ColorPrint() takes a string and a ConsoleColor as parameters and prints the text in the given color while returning to the original ForegroundColor from before execution.

Example Code:

```
Console.WriteLine("This will be printed in the set foreground color, standard is white.");
ECH.ColorPrint("This will be printed in blue.", ConsoleColor.Blue);
Console.WriteLine("This will be in white again.");
```

### ECH.ErrorPrint()
ErrorPrint() takes a string as parameter and prints the text in red as an error while returning to the original ForegroundColor from before execution.

Example Code:

```
Console.WriteLine("This will be printed in the set foreground color, standard is white.");
ECH.ErrorPrint("This will be printed in red.");
Console.WriteLine("This will be in white again.");
```

Example Output:

```
This will be printed in the set foreground color, standard is white.
Error: This will be printed in red.
This will be in white again.
```
