# Task

## Definition:
### A Task represents an asynchronous operation.

## Namespace:
```
using System.Threading.Tasks;

```
### Creating a Task:

```
Task task = Task.Run(MethodName);

```
## Waiting for a Task:

```
task.Wait();

```
### Advantages:
- Simpler than Thread
- Uses the .NET Thread Pool
- Represents asynchronous work
- Works seamlessly with async and await

### Common Methods:
- Task.Run()
- Wait()
- IsCompleted
- Status


## Diagram

```
Main()
   │
   ▼
Task.Run(DoWork)
   │
   ├──────────────► Task Starts
   │                     │
   ▼                     ▼
Main Continues      DoWork()
   │                     │
   ▼                     ▼
task.Wait() ◄─────────────┘
   │
   ▼
Program Ends

```

## Why use Task?

### Without task:

```
Main
 │
 ▼
DoWork()
 │
 ▼
Wait 3 sec
 │
 ▼
Continue

```
### The main method is blocked.

### With task:

```
Main
 │
 ▼
Task.Run()
 │
 ├────► Task Executes
 │
 ▼
Main Continues
 │
 ▼
Wait()
 │
 ▼
End

```
### The main method can continue doing other work while the task runs.