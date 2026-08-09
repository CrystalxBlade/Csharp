==================================================
Task<T>
==================================================

Definition:

Task<T> represents an asynchronous operation
that eventually returns a value of type T.


Task
-----
Used when an asynchronous method does not
return a value.

Example:

async Task PrintMessage()
{
    await Task.Delay(1000);
}


Task<T>
--------
Used when an asynchronous method returns
a value.

Example:

async Task<int> GetNumber()
{
    await Task.Delay(1000);

    return 100;
}


Common Examples:

Task<int>
Task<string>
Task<bool>
Task<Student>
Task<List<Student>>


Comparison:

void       → Task

int        → Task<int>

string     → Task<string>

Student    → Task<Student>


Getting the Result:

int number = await GetNumber();

string name = await GetName();

Student student = await GetStudent();


Important:

Task<T> is NOT the actual result.

Task<int> = asynchronous operation that
            will produce an int.

await Task<int> = actual int result.