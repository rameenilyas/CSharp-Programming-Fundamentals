
````markdown
# Module 5: User Input & Output

## 1. User Input

In C#, `Console.ReadLine()` is used to take input from the user.

### Syntax

```csharp
Console.ReadLine();
````

### Example

```csharp
Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Your name is: " + name);
```

### Explanation

* `Console.Write()` displays a message on the screen.
* `Console.ReadLine()` takes input from the user.
* `string name` stores the user's input.

---

## 2. Output

In C#, `Console.WriteLine()` is used to display output on the screen.

### Example

```csharp
int age = 20;

Console.WriteLine("Your age is: " + age);
```

### Output

```text
Your age is: 20
```

### Console.Write() vs Console.WriteLine()

`Console.Write()` displays output on the same line.

```csharp
Console.Write("Hello ");
Console.Write("World");
```

Output:

```text
Hello World
```

`Console.WriteLine()` moves to the next line after displaying the output.

```csharp
Console.WriteLine("Hello");
Console.WriteLine("World");
```

Output:

```text
Hello
World
```

---

## 3. Multiple Inputs

Multiple inputs means taking more than one value from the user.

### Example

```csharp
Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your marks: ");
int marks = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Marks: " + marks);
```

### Explanation

* `name` stores a string input.
* `age` stores an integer input.
* `marks` stores an integer input.
* `Convert.ToInt32()` converts the input into an integer.

---

## 4. Formatting Output

Output formatting means displaying information in a clean and readable way.

### Example

```csharp
string name = "Ramee";
int age = 20;
int marks = 85;

Console.WriteLine("--- Student Information ---");
Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Marks: " + marks);
```

### Output

```text
--- Student Information ---
Name: Ramee
Age: 20
Marks: 85
```

---

## 5. String Interpolation

String interpolation is another way to display variables inside a string.

It uses the `$` symbol.

### Example

```csharp
string name = "Ramee";
int age = 20;

Console.WriteLine($"Name: {name}");
Console.WriteLine($"Age: {age}");
```

### Output

```text
Name: Ramee
Age: 20
```

---

## Important Methods

| Method                | Purpose                                    |
| --------------------- | ------------------------------------------ |
| `Console.ReadLine()`  | Takes input from the user                  |
| `Console.Write()`     | Displays output on the same line           |
| `Console.WriteLine()` | Displays output and moves to the next line |
| `Convert.ToInt32()`   | Converts input to an integer               |

## Quick Summary

* `Console.ReadLine()` → User Input
* `Console.Write()` → Displays output on the same line
* `Console.WriteLine()` → Displays output and moves to the next line
* `Convert.ToInt32()` → Converts input into an integer
* `$"..."` → Used for string interpolation


