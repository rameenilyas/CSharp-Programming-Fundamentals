

## 📘 Module 09 — Functions

### 1. What is a Function?

A **function** is a block of code that performs a specific task.

Functions help us:

* Reuse code
* Organize programs
* Reduce repeated code
* Make programs easier to understand

### 2. Why Use Functions?

Instead of writing the same code again and again, we can write it once inside a function and call it whenever needed.

### 3. Basic Function Syntax

```csharp
returnType FunctionName()
{
    // Code
}
```

Example:

```csharp
static void SayHello()
{
    Console.WriteLine("Hello!");
}
```

### 4. Calling a Function

A function runs when we **call** it.

```csharp
SayHello();
```

### 5. `void` Function

A `void` function does not return a value.

```csharp
static void Welcome()
{
    Console.WriteLine("Welcome to C#");
}
```

### 6. Function with Parameters

Parameters allow us to send information to a function.

```csharp
static void Greet(string name)
{
    Console.WriteLine("Hello " + name);
}
```

Calling:

```csharp
Greet("Rameen");
```

### 7. Multiple Parameters

A function can have more than one parameter.

```csharp
static void Add(int a, int b)
{
    Console.WriteLine(a + b);
}
```

Calling:

```csharp
Add(5, 3);
```

Output:

```text
8
```

### 8. Function with Return Value

A function can return a value using the `return` keyword.

```csharp
static int Add(int a, int b)
{
    return a + b;
}
```

Calling:

```csharp
int result = Add(5, 3);
Console.WriteLine(result);
```

Output:

```text
8
```

### 9. `return` Keyword

The `return` keyword sends a value back from the function.

```csharp
return a + b;
```

### 10. Function Parameters vs Arguments

**Parameter:** Variable written in the function definition.

```csharp
static void Greet(string name)
```

Here `name` is a **parameter**.

**Argument:** Actual value passed when calling the function.

```csharp
Greet("Rameen");
```

Here `"Rameen"` is an **argument**.

### 11. Types of Functions

Common types:

1. Function without parameters and without return value
2. Function with parameters and without return value
3. Function without parameters but with return value
4. Function with parameters and with return value

### 12. Example of All Four

**1. No parameter, no return:**

```csharp
static void Message()
{
    Console.WriteLine("Hello");
}
```

**2. Parameter, no return:**

```csharp
static void Square(int number)
{
    Console.WriteLine(number * number);
}
```

**3. No parameter, return value:**

```csharp
static int GetNumber()
{
    return 10;
}
```

**4. Parameter and return value:**

```csharp
static int Multiply(int a, int b)
{
    return a * b;
}
```

### ⭐ Key Points

* **Function** = reusable block of code
* **Calling a function** = running the function
* **Parameter** = input variable
* **Argument** = actual value
* **`void`** = no return value
* **`return`** = sends a value back
* Functions make code **reusable, organized, and easier to maintain**.
