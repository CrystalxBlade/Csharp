==================================================
Task.WhenAny()
==================================================

## Definition:

###Task.WhenAny() waits for multiple Tasks and returns when the FIRST Task completes.

## Purpose:

- Wait for the first completed Task.
- Continue without waiting for the remaining Tasks.
- Useful when only the first available result is needed.


### Example:

```
Task<string> task1 = DownloadFile("File 1", 4);
Task<string> task2 = DownloadFile("File 2", 2);
Task<string> task3 = DownloadFile("File 3", 5);

Task<string> completedTask =
    await Task.WhenAny(task1, task2, task3);

string result = await completedTask;

```
### Execution:

```
Task 1 ───────────────► Finished
Task 2 ─────► Finished ← FIRST
Task 3 ─────────────────────►

              ↓

         Continue


WhenAll vs WhenAny:

WhenAll
    ↓
Wait for ALL Tasks

WhenAny
    ↓
Wait for ANY ONE Task

```
## Important:

### Task.WhenAny() returns the Task that completed first.

### It does NOT automatically cancel the other Tasks.

### The remaining Tasks can continue running.