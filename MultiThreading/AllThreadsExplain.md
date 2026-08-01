
## Join

```
Thread.Join()

Definition:
Join() blocks the calling thread until the target thread finishes execution.

Syntax:
thread.Join();

Purpose:
• Wait for another thread to complete
• Synchronize thread execution

Without Join():
Main thread continues immediately.

With Join():
Main thread waits until the worker thread finishes.

```
### Without Join()

```
Main Thread
│
├── Start Worker
├── Main Finished ✅
│
└────────────► Worker Thread
              1
              2
              3
              4
              5
```
### With Join()

```
Main Thread
│
├── Start Worker
├── Join()
│     │
│     ▼
│   Wait...
│
└────────────► Worker Thread
              1
              2
              3
              4
              5
              Finished
│
▼
Main Finished

```
## Foreground and Background Thread

```
Foreground Thread

Definition:
A Foreground Thread keeps the application running until it finishes execution.

Default:
Every new thread is a Foreground Thread.

Background Thread

Definition:
A Background Thread automatically stops when all Foreground Threads have finished.

Syntax:

thread.IsBackground = true;

Difference:

Foreground Thread
✓ Keeps application alive

Background Thread
✗ Does not keep application alive

Uses:

Foreground
• Database operations
• Payments
• File saving

Background
• Logging
• Notifications
• Auto Save
• Cache cleanup

```
### Foreground Thread

```
Application Starts
       │
       ▼
Main Thread
       │
       ▼
Foreground Thread
       │
       ▼
Application waits...
       │
       ▼
Thread Finished
       │
       ▼
Application Closes

```

### Backgoround Thread

```
Application Starts
       │
       ▼
Main Thread
       │
       ▼
Background Thread
       │
       ▼
Main Thread Ends
       │
       ▼
Application Closes
       │
       ▼
Background Thread Stops

```
## Race Condition

```
Race Condition

Definition:
A Race Condition occurs when two or more threads access and modify shared data simultaneously, causing unpredictable results.

Cause:
• Shared data
• Multiple threads
• No synchronization

Problem:
Incorrect output.

Solution:
Use synchronization techniques such as:
• lock
• Monitor
• Mutex
• Semaphore

```

```
Counter = 5

        Thread 1              Thread 2
            │                     │
            ▼                     ▼
        Read 5                Read 5
            │                     │
            ▼                     ▼
        Add 1                 Add 1
            │                     │
            ▼                     ▼
       Write 6              Write 6

Final Counter = 6 ❌
Expected = 7

```

## Lock Keyword

```
lock Keyword

Definition:
The lock keyword ensures that only one thread can execute a block of code at a time.

Syntax:

lock(lockObject)
{
    // Critical Section
}

Purpose:
• Prevent Race Conditions
• Protect Shared Resources
• Ensure Thread Safety

How it Works:
1. Thread enters the lock.
2. Other threads wait.
3. Thread completes its work.
4. Lock is released.
5. Next waiting thread enters.

Best Practice:
Create a private object for locking.

private static readonly object lockObject = new object();

```

### Without Lock 

```
Counter = 5

Thread 1              Thread 2
   │                     │
   ▼                     ▼
 Read 5               Read 5
   │                     │
   ▼                     ▼
 Add 1                Add 1
   │                     │
   ▼                     ▼
Write 6              Write 6

Final Counter = 6 ❌

```
### with Lock

```
Counter = 5

Thread 1
   │
   ▼
Enters lock
   │
Read 5
   │
Add 1
   │
Write 6
   │
Leaves lock
   │
   ▼

Thread 2
   │
Waits...
   │
Enters lock
   │
Read 6
   │
Add 1
   │
Write 7
   │
Leaves lock

Final Counter = 7 ✅

```
## Task

```
Task

Definition:
A Task represents an asynchronous operation.

Namespace:
using System.Threading.Tasks;

Syntax:

Task task = Task.Run(MethodName);

Purpose:
• Execute work asynchronously.
• Improve application performance.
• Keep applications responsive.

Advantages:
• Easier than Thread
• Uses the Thread Pool
• Better performance
• Modern approach

Task.Wait():
Waits until the task finishes.

Difference:

Thread
- Manual thread creation
- Older API

Task
- High-level API
- Recommended in modern C#

```

```
Program
     │
     ▼
Main Thread
     │
     ▼
Task.Run()
     │
     ▼
Thread Pool
     │
     ▼
Executes PrintNumbers()
     │
     ▼
Task Finished

```

### Why use Task instead of Thread?

- Thread

```
Program
    │
    ▼
Create Thread
    │
    ▼
Start Thread
    │
    ▼
Manage Thread Yourself

```

- Task

```
Program
    │
    ▼
Task.Run()
    │
    ▼
.NET Handles Everything

```

| Thread                                | Task                               |
| ------------------------------------- | ---------------------------------- |
| `Thread thread = new Thread(Method);` | `Task task = Task.Run(Method);`    |
| `thread.Start();`                     | Starts automatically               |
| `thread.Join();`                      | `task.Wait();`                     |
| Creates a new thread                  | Uses the Thread Pool when possible |
| More manual work                      | Easier to use                      |
| Older approach                        | Modern approach                    |
