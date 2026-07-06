## What is a Stack?

### A Stack<T> is a collection that follows the LIFO (Last In, First Out) principle.

### Think of a stack of plates 🍽️.

```
Top
┌────────┐
│ Plate3 │ ← Last plate added
├────────┤
│ Plate2 │
├────────┤
│ Plate1 │ ← First plate added
└────────┘
```

### You can only take the top plate.


## Why not use List<T>?

### You could.

```
List<int> numbers = new List<int>();

```

### But imagine you want to make sure people only add and remove from the end.

### A Stack<T> enforces that rule.

### It only allows:

```
Push() → Add to the top
Pop() → Remove from the top
Peek() → Look at the top

```
### This makes your code express your intent more clearly.



## Real-world uses of Stack
### 1. Undo Feature ⭐⭐⭐⭐⭐

### This is the most common example.

### Imagine Microsoft Word.

```
Type A
Type B
Type C

```
### Stack:

```
Top
C
B
A

```
### Press Undo:

```
Pop()

```
### "C" disappears.

### Press Undo again:

```
Pop()

```

### "B" disappears.

## 2. Browser Back Button ⭐⭐⭐⭐⭐

### Suppose you visit:

```
Google
↓
YouTube
↓
GitHub
↓
Stack Overflow

```
### A stack stores:

```
Top
Stack Overflow
GitHub
YouTube
Google

```
### Press Back:

```
Pop()

```
### You return to GitHub