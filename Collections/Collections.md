# What are Collections in C#?

A **Collection** is a group of objects stored together in a single variable. Collections make it easy to store, organize, access, search, add, and remove multiple items efficiently.

Unlike arrays, many collections can automatically grow or shrink in size as needed.

## Example

```csharp
List<string> fruits = new List<string>();

fruits.Add("Apple");
fruits.Add("Banana");
fruits.Add("Mango");
```

Output:

```
Apple
Banana
Mango
```

## Why Do We Use Collections?

Collections are used to:

- Store multiple objects
- Add or remove items dynamically
- Search for data efficiently
- Organize data in different ways
- Improve code readability and performance

## Common Collections in C#

- List<T>
- Dictionary<TKey, TValue>
- Stack<T>
- Queue<T>
- HashSet<T>