### 03-FunctionWithParameter.cs

```csharp
using System;

class Program
{
    static void Main()
    {
        GreetUser("Rameen");
    }

    static void GreetUser(string name)
    {
        Console.WriteLine("Hello, " + name + "!");
    }
}
```

### Explanation

**1. `GreetUser("Rameen");`**
This calls the function and passes `"Rameen"` as an argument.

**2. `string name`**
`name` is a **parameter**. It receives the value passed to the function.

**3. `Console.WriteLine()`**
It displays the greeting message using the value stored in `name`.

### Output

```text
Hello, Rameen!
```

### Key Concept

A **parameter** allows us to pass data into a function. This makes the function more flexible and reusable.
