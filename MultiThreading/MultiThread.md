# Multithreading in C#

## What is Multithreading?

Think of it like this:

### Process = A running application (e.g., Chrome, Visual Studio).
## Thread = A worker inside that application.

Multithreading is the process of running **multiple threads (tasks)** inside a single application at the same time.

A thread is the **smallest unit of execution** in a program.

Instead of doing one task after another, multithreading allows multiple tasks to run concurrently.


### Every application by default contains on thread to execute the program and that program is know as Main Thread, so every program is by default single thread model.

---

## Real Life Example

Imagine a restaurant.

👨‍🍳 One Chef

Order 1 → Finish → Order 2 → Finish → Order 3

Everything waits.

---

👨‍🍳👨‍🍳👨‍🍳 Three Chefs

Order 1
Order 2
Order 3

All are prepared at the same time.

This is exactly how multithreading works.

---

## Program Execution

Without Multithreading

```

Program
|
+-- Main Thread
|
+-- Task 1
|
+-- Task 2
|
+-- Task 3

```

Everything waits for the previous task.

---

With Multithreading

```

Program
|
+-- Main Thread
|
+-- Thread 1 --> Task 1
|
+-- Thread 2 --> Task 2
|
+-- Thread 3 --> Task 3

```

All tasks execute simultaneously (or are scheduled concurrently by the OS).

---

## Why do we use Multithreading?

- Improve application performance
- Run background tasks
- Keep UI responsive
- Download multiple files simultaneously
- Process large amounts of data
- Build games and servers

---

## Namespace

```csharp
using System.Threading;
using System.Threading.Tasks;
```

---

# Important Classes

| Class | Purpose |
|--------|----------|
| Thread | Create a new thread |
| Task | Modern way to run work asynchronously |
| ThreadPool | Reuses threads for better performance |
| Monitor | Thread synchronization |
| Mutex | Synchronization between processes |
| Semaphore | Limit number of threads |
| lock | Prevent race conditions |

---

# Thread Life Cycle

```

New
|
v

Running
|
v

Waiting / Sleep
|
v

Running
|
v

Stopped

```

---

# Thread States

```
Unstarted
Running
WaitSleepJoin
Stopped
Background
```

---

# Thread Methods

```csharp
Start()
Sleep()
Join()
Interrupt()
Abort()   // Obsolete
```

---

# Important Concepts

## 1. Main Thread

Every C# application starts with one thread.

```
Main()
```

This is called the Main Thread.

---

## 2. Worker Thread

A thread created by the programmer.

```
Thread t = new Thread(Print);
```

---

## 3. Background Thread

Stops automatically when the application ends.

```
thread.IsBackground = true;
```

---

## 4. Foreground Thread

Keeps the application alive until it finishes.

(Default thread)

---

## 5. Sleep()

Pauses a thread.

```csharp
Thread.Sleep(2000);
```

Waits for 2 seconds.

---

## 6. Join()

Makes one thread wait for another.

```csharp
thread.Join();
```

---

## 7. Lock

Only one thread can access a resource at a time.

```csharp
lock(obj)
{
    // Critical Section
}
```

---

## 8. Race Condition

Occurs when two or more threads modify the same data simultaneously.

Example

```

Thread A
Balance = 1000

Thread B
Balance = 1000

Both Withdraw 500

Expected = 0
Actual = 500

```

Wrong result.

---

## 9. Synchronization

Coordinates multiple threads safely.

Tools:

- lock
- Mutex
- Semaphore
- Monitor

---

## Thread vs Task

| Thread | Task |
|---------|------|
| Low-level | High-level |
| Manual thread management | Managed by .NET |
| Slower | Faster |
| More memory | Less memory |
| Older approach | Recommended approach |

---

## Interview Questions

### What is a Thread?

Smallest unit of execution inside a process.

---

### Why use Multithreading?

To execute multiple tasks simultaneously and improve performance.

---

### Difference between Process and Thread?

| Process | Thread |
|----------|---------|
| Independent program | Part of a process |
| Own memory | Shares process memory |
| Heavyweight | Lightweight |

---

### What is Race Condition?

Multiple threads modifying shared data simultaneously causing incorrect results.

---

### What is Lock?

Prevents multiple threads from entering the same critical section at the same time.

---

### What is Join()?

Makes one thread wait until another finishes.

---

### What is Sleep()?

Temporarily pauses a thread.

---

### Which is preferred today?

✅ Task Parallel Library (Task)

instead of

❌ Thread class

---

# Recommended Order

```

1. Thread
↓

2. ThreadStart

↓

3. ParameterizedThreadStart

↓

4. Sleep()

↓

5. Join()

↓

6. Background Thread

↓

7. Foreground Thread

↓

8. Lock

↓

9. Race Condition

↓

10. Monitor

↓

11. Mutex

↓

12. Semaphore

↓

13. ThreadPool

↓

14. Task

↓

15. async / await

```

---

# Summary

- Every program starts with one Main Thread.
- Threads allow multiple tasks to run concurrently.
- Use `lock` to avoid race conditions.
- `Thread` is the classic API.
- `Task` is the modern and recommended approach.
- `async`/`await` are built on top of `Task` for asynchronous programming.

# Advantages

## 1. Faster Program Execution ⚡
## 2. Responsive Applications
## 3. Better CPU Utilization
## 4. Multiple Users at the Same Time
## 5. Time Sharing

