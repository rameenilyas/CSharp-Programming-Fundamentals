# 📘 01. Structure of a C# Program

## 📖 Definition

A C# program has a specific structure that helps the compiler understand and execute the code correctly.

---

## 🏗️ Basic Structure of a C# Program

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```

---

## 🔍 Explanation

### 1. using System;

- Imports the **System** namespace.
- It allows us to use classes like `Console`.

### 2. class Program

- Defines a class named **Program**.
- Every C# application contains at least one class.

### 3. Main() Method

- The starting point of every C# application.
- Execution begins from the `Main()` method.

### 4. Console.WriteLine()

- Displays output on the screen.
- After printing, the cursor moves to the next line.

---

## 🎯 Key Points

- Every C# program starts from the `Main()` method.
- Statements end with a semicolon (`;`).
- Curly braces `{ }` define a block of code.

---

## 📌 Exam Definition

**Structure of a C# Program:**  
A C# program consists of using directives, a class, the `Main()` method, and executable statements.

---

## 💡 Output

```
Hello, World!
```
