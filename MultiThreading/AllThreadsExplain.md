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