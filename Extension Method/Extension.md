# Extension Methods in C#

## Definition

Extension Methods allow us to add new methods to existing classes without modifying the original class.

---

## Why use Extension Methods?

- Add functionality to existing classes.
- Improve code readability.
- Used heavily by LINQ.
- No need to inherit from a class.

---

## Rules

1. Extension Method must be inside a static class.
2. Extension Method must be static.
3. The first parameter must use the `this` keyword.

Example:

```csharp
public static void Print(this string text)
{
    Console.WriteLine(text);
}
```

Usage:

```csharp
string name = "Blade";
name.Print();
```

---

## Topics Covered

- String Extension Method
- Integer Extension Method
- Extension Method with Parameters
- Extension Method with Return Value

---

## Real World Usage

LINQ methods such as:

- Where()
- Select()
- OrderBy()
- ToList()

are Extension Methods.

Example:

```csharp
students.Where(s => s.Marks > 80);
```

Without Extension Methods:

```csharp
Enumerable.Where(students, s => s.Marks > 80);
```

Extension Methods make code cleaner and easier to read.