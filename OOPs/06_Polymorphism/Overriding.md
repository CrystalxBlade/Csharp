## ✅ Method Overriding

**Method Overriding** is a concept in **Runtime Polymorphism** where a **derived class** provides a **specific implementation** of a method that is already defined in its **base class**.

---

### 🧠 Key Points:

- Base class method must be marked with the **`virtual`** keyword.
- Derived class method must use the **`override`** keyword.
- It lets the derived class **modify or extend** the behavior of the base class method.



### ❗ Difference Between Overloading and Overriding

| Feature | Overloading | Overriding |
| --- | --- | --- |
| Based On | Method Signature (parameters) | Inheritance (base and derived class) |
| When? | Compile-time | Runtime |
| Keywords | No keyword needed | `virtual` in base, `override` in derived |
| Class Type | Same class | Different classes (inheritance) |