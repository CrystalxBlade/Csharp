An **abstract class** in C# is a class that **cannot be instantiated directly** and is meant to be **inherited** by other classes. It can **define both complete (concrete) methods** and **incomplete (abstract) methods** that must be implemented by derived classes.

---

### ✅ Key Points:

- Use the `abstract` keyword before the class name.
- Cannot create an object of an abstract class.
- Can have:
    - Fields
    - Constructors
    - Abstract methods (no body)
    - Non-abstract (concrete) methods (with body)
- Designed to provide a **base class for other classes**.

---

### 🧠 Why Use It?

To provide a **common blueprint** or **template** for subclasses.