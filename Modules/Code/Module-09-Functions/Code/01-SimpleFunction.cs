
### 01-SimpleFunction.cs

```csharp
using System;

class Program
{
    static void Main()
    {
        SayHello();
    }

    static void SayHello()
    {
        Console.WriteLine("Hello, World!");
    }
}
```

### Explanation

**1. `Main()` Method**
The `Main()` method is the starting point of the C# program.

**2. `SayHello()` Function Call**
`SayHello();` calls the function and tells the program to execute it.

**3. `SayHello()` Function**
This is a user-defined function. It contains the code that prints a message.

**4. `Console.WriteLine()`**
It displays text on the screen.

### Output

```text
Hello, World!
```

### Key Concept

A **function** is a reusable block of code that performs a specific task. Instead of writing the same code again and again, we can create a function and call it whenever we need it.
