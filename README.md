# Problems

A common approach to structure unit tests in .NET is to copy a tested 
project structure to a project with unit tests, e.g.:

```
/Solution
|__/Crm.Application
   |__/Commands
      |__/User
         |__CreateUserCommand.cs
         |__UpdateUserCommand.cs
         |__DeleteUserCommand.cs
|__/Crm.Application.Tests
   |__/Commands
      |__/User
         |__CreateUserCommandTests.cs
         |__UpdateUserCommandTests.cs
         |__DeleteUserCommandTests.cs
```

Now you have to:

* Manually create directories that you've already created, but in another 
parent directory;
* Maintain these directories during refactorings and rename or replace them 
manually;
* Track stale directories;
* Look at the garbage during MRs.

If nothing from these bother you - it's totally ok, but I'm exhausted with 
tons of `mkdir` and `Cmd+C / Cmd+V` commands.

# Solution

## Inspiration

Go has a nice approach with unit testing directories structure:

* You create a `tested_filename_test.go` file near a `tested_file.go`;
* Write unit tests in `tested_filename_test.go` and code in `tested_file.go`;
* `go test` run tests, but `go run` and `go build` completely ignores them and
all test dependencies.

## Implementation

* Disable default compile items;
* Split dependencies in two groups. One for tests and one for a project;
* Add different compile items when you need test dependencies and when you don't.

## Result

* `make run` will run an application;
* `make test` will test it;
* `make publish` will publish it without any test dependency or test code;
* And you can maintain one set of directories and create tests near tested code.