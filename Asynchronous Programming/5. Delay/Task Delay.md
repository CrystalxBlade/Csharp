# Task.Delay()

## Definition: Creates an asynchronous, non-blocking delay.

```
await Task.Delay(milliseconds);

```

```
await Task.Delay(2000); // 2 seconds

```

### Purpose

- Pause execution asynchronously

- Keep applications responsive

- Avoid blocking threads

- Simulate long-running operations

### Common Uses

- Loading screens

- Retry logic

- Polling APIs

- Timeouts

- Animations and timers

### Important

- Must usually be used with await.

- Returns a Task.

- Does not block the current thread.

- Preferred over Thread.Sleep() in asynchronous code.


# Why is Task.Delay() better?

## Imagine a web server handling 1000 users.

### Thread.Sleep(3000) would keep many threads blocked.

### Task.Delay(3000) lets those threads return to the thread pool and serve other users.

- This is why ASP.NET Core uses asynchronous APIs heavily.


