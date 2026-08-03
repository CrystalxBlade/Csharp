What is Asynchronous Programming?

Definition:
Asynchronous Programming allows a program to perform tasks without blocking the current thread while waiting for an operation to complete.

Examples:
• Downloading files
• Calling Web APIs
• Reading/Writing files
• Database operations

Synchronous Programming
------------------------
• Executes one task at a time.
• The current thread waits until the task finishes.
• Uses Thread.Sleep() for delays.

Asynchronous Programming
------------------------
• Doesn't block the current thread while waiting.
• Uses async and await.
• Uses Task and Task.Delay().

Benefits
--------
• Better responsiveness
• Efficient use of threads
• Ideal for I/O operations

### Synchronous

```
Main Thread
     │
     ▼
Start Download
     │
     ▼
Thread.Sleep()
     │
  Thread is blocked
     │
     ▼
Download Finished

```
### Asynchronous

```
Main Thread
     │
     ▼
Start Download
     │
     ▼
await Task.Delay()
     │
 Thread is NOT blocked
     │
     ▼
Continue when delay completes
     │
     ▼
Download Finished

```