
````markdown
# Module 5: User Input & Output

## 1. User Input

C# mein user se input lene ke liye `Console.ReadLine()` use hota hai.

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

* `Console.Write()` → message screen par display karta hai.
* `Console.ReadLine()` → user se input leta hai.
* `string name` → user ki input ko store karta hai.

---

## 2. Output

C# mein output display karne ke liye `Console.WriteLine()` use hota hai.

### Example

```csharp
int age = 20;

Console.WriteLine("Your age is: " + age);
```

### Output

```text
Your age is: 20
```

### `Console.Write()` vs `Console.WriteLine()`

`Console.Write()` same line par output rakhta hai.

```csharp
Console.Write("Hello ");
Console.Write("World");
```

Output:

```text
Hello World
```

`Console.WriteLine()` output ke baad next line par chala jata hai.

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

Jab program mein user se ek se zyada values leni hon, usay multiple inputs kehte hain.

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

* `name` → string input store karta hai.
* `age` → integer input store karta hai.
* `marks` → integer input store karta hai.
* `Convert.ToInt32()` → text input ko integer mein convert karta hai.

---

## 4. Formatting Output

Formatting output ka matlab hai information ko **clean aur readable format** mein display karna.

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

C# mein output ko aur clean banane ke liye **string interpolation** use kar sakte hain.

Ismein `$` symbol use hota hai.

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

| Method                | Purpose                                 |
| --------------------- | --------------------------------------- |
| `Console.ReadLine()`  | User se input lena                      |
| `Console.Write()`     | Output same line par display karna      |
| `Console.WriteLine()` | Output display karke next line par jana |
| `Convert.ToInt32()`   | Input ko integer mein convert karna     |

## Quick Summary

* `Console.ReadLine()` → Input 📥
* `Console.Write()` → Output same line par
* `Console.WriteLine()` → Output + next line
* `Convert.ToInt32()` → String input ko integer mein convert karta hai
* `$"..."` → String interpolation ke liye




