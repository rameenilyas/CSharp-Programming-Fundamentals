# 📘 03. Input and Output in C#

## 📖 Definition

Input means taking data from the user, while Output means displaying information on the screen.

---

# Output

Output is displayed using the `Console.Write()` and `Console.WriteLine()` methods.

## Console.WriteLine()

- Displays output.
- Moves the cursor to the next line.

### Example

```csharp
Console.WriteLine("Hello World");
Console.WriteLine("Welcome to C#");
```

### Output

```
Hello World
Welcome to C#
```

---

## Console.Write()

- Displays output.
- Does NOT move the cursor to the next line.

### Example

```csharp
Console.Write("Hello ");
Console.Write("World");
```

### Output

```
Hello World
```

---

# Input

Input is taken using the `Console.ReadLine()` method.

### Example

```csharp
Console.Write("Enter your name: ");
string name = Console.ReadLine();

Console.WriteLine("Welcome " + name);
```

---

## 🎯 Key Points

- `Console.Write()` prints on the same line.
- `Console.WriteLine()` prints and moves to the next line.
- `Console.ReadLine()` takes input from the user.

---

## 📌 Exam Definition

Input is the process of taking data from the user, while Output is the process of displaying information on the screen.
