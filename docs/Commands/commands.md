# Commands

Commands are be defined by methods and classes.

Using our calculator example...

```c#
public class Calculator
{
    public void Add(int value1, int value2)
    {
        Console.WriteLine($"Answer:  {value1 + value2}");
    }

    public void Subtract(int value1, int value2)
    {
        Console.WriteLine($"Answer:  {value1 - value2}");
    }
}

class Program
{
    static int Main(string[] args)
    {
        return new AppRunner<Calculator>().Run(args);
    }
}
```

__Calculator__ is the root command and is not directly referenced in the terminal.

__Add__ and __Subtract__ are the commands. 

Command methods must:

* be `public`
* return `void`, `int`, `Task` or `Task<int>`

Command methods may be async.

When the return type is `int` or `Task<int>` the value is used as the exit code.

## Command Attribute

Every public method will be interpreted as a command and the command name will be the method name.

Use the `[Command]` attribute to change the command name, enhance help output and provide parser hints.

```c#
public class Calculator
{
    [Command(Name="sum",
        Usage="sum <int> <int>",
        Description="sums two numbers",
        ExtendedHelpText="more details and examples")]
    public void Add(int value1, int value2)
    {
        Console.WriteLine($"Answer:  {value1 + value2}");
    }
}
```

```bash
~
$ dotnet calculator.dll sum --help

dotnet calculator.dll sum -h
sums two numbers

Usage: sum <int> <int>

Arguments:

  value1  <NUMBER>

  value2  <NUMBER>

more details and examples

```

!!! Note
    Use of `[Command]` attribute is optional and only required when you want to add any customizations. 

Use `IgnoreUnexpectedOperands` & `ArgumentSeparatorStrategy` to override argument parsing behavior for the command. See [Argument Separator](../ArgumentValues/argument-separator.md) for more details.

Use `Description` & `ExtendedHelpText` to include those values in help output for the command.

Use `Usage` to override the auto-generated usage section in the help output for the command.

!!! Note
    If you're looking to change the app name, set `AppSettings.Help.UsageAppName` and use the `%AppName%` template variable mentioned below.

### Template variables

Two template variables are available for use in Usage, Description and ExtendedHelpText: `%AppName%` and `%CmdPath%`

#### AppName

Use `%AppName%` to include the name as calculated by CommandDotNet. This will use `AppSettings.Help.UsageAppName` if it's set.

```c#
[Command(Usage ="%AppName% sum <int> <int>")]
public class Calculator{ ... }
```
results in help with `Usage: dotnet calculator.dll sum <int> <int>`

See this line `"Example: %AppName% [debug] [parse] [log:info] cancel-me"` in the [Example app](https://github.com/bilal-fazlani/commanddotnet/blob/master/CommandDotNet.Example/Examples.cs#L14).

#### CmdPath

Use `%CmdPath%` to include the full path of commands. This is helpful when working with subcommands.

```c#
[Command(Usage ="%CmdPath% <int> <int>")]
public class Calculator{ ... }
```
results in help with `Usage: sum <int> <int>`

## Default Method

Let's refactor our calculator. Let's rename the application to Add with the single Add command.

```c#
public class Calculator
{
    public void Add(int value1, int value2)
    {
        Console.WriteLine($"Answer:  {value1 + value2}");
    }
}
```

Now executed as

```bash
dotnet add.dll Add 1 2
```

If the root command has only one command, you may want to exectute it by default without specifying any commands names. We can do this with the `[DefaultCommand]` attribute.

```c#
public class Calculator
{
    [DefaultCommand]
    public void Add(int value1, int value2)
    {
        Console.WriteLine($"Answer:  {value1 + value2}");
    }
}
```

Now executed as

```bash
dotnet add.dll 1 2
```
