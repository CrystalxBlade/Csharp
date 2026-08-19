==================================================
Task.WhenAll()
==================================================

## Definition:

### Task.WhenAll() is used to wait for multiple
### asynchronous operations to complete.

## Purpose:

- Run multiple independent tasks concurrently.
- Wait until all tasks finish.
- Get all results together when using Task<T>.

### Example:

```
Task<string> task1 = DownloadFile("File 1", 3);
Task<string> task2 = DownloadFile("File 2", 2);
Task<string> task3 = DownloadFile("File 3", 4);

string[] results =
    await Task.WhenAll(task1, task2, task3);

```

```
Execution:

Start Task 1
Start Task 2
Start Task 3
        ↓
Wait for all
        ↓
All completed
        ↓
Continue

```
## Important:

### Task.WhenAll() does NOT mean "create three threads."

### It combines multiple Tasks and lets you await their completion as a group.


## Sequential:

```
await task1;
await task2;
await task3;

```

## WhenAll:

```
await Task.WhenAll(task1, task2, task3);

```
### WhenAll is useful when tasks are independent and can run at the same time.


## What happens

- The three operations are started:

```
                Task.WhenAll()
                     │
        ┌────────────┼────────────┐
        ▼            ▼            ▼
     File 1       File 2       File 3
      3 sec        2 sec        4 sec
        │            │            │
        ▼            ▼            ▼
    Finished      Finished      Finished
        │            │            │
        └────────────┼────────────┘
                     ▼
             All tasks finished
                     │
                     ▼
                 Continue

```