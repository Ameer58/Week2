# Week2

In this week we covered the following topics:

- *Introduction to C#*
- Refactoring and unit testing
- Test-fist development
- Operators and Control flow
- Exceptions
- Numerical Data Types
- Strings
- DateTime and Enums
- .Net Memory Model
- Methods

<br>
<br>

## **Introduction to C#**

.NET is a developer platform made up of tools, programming languages, and libraries for building many different types of applications.

There are various implementations of .NET. Each implementation allows .NET code to execute in different places—Linux, macOS, Windows, iOS, Android, and many more.

.NET Framework is the original implementation of .NET. It supports running websites, services, desktop apps, and more on Windows.
.NET is a cross-platform implementation for running websites, services, and console apps on Windows, Linux, and macOS. .NET is open source on GitHub. .NET was previously called .NET Core.
Xamarin/Mono is a .NET implementation for running apps on all the major mobile operating systems, including iOS and Android.
.NET Standard is a formal specification of the APIs that are common across .NET implementations. This allows the same code and libraries to run on different implementations.

The two major components of .NET Framework are the Common Language Runtime and the .NET Framework Class Library.

The Common Language Runtime (CLR) is the execution engine that handles running applications. It provides services like thread management, garbage collection, type-safety, exception handling, and more.

The **Class Library** provides a set of APIs and types for common functionality. It provides types for strings, dates, numbers, etc. The Class Library includes APIs for reading and writing files, connecting to databases, drawing, and more.
.NET applications are written in the C#, F#, or Visual Basic programming language. Code is compiled into a language-agnostic Common Intermediate Language (CIL). Compiled code is stored in assemblies—files with a .dll or .exe file extension.

When an app runs, the **CLR** takes the assembly and uses a just-in-time compiler (JIT) to turn it into machine code that can execute on the specific architecture of the computer it is running on.
C# programs consist of one or more files. Each file contains zero or more namespaces. A namespace contains types such as classes, structs, interfaces, enumerations, and delegates, or other namespaces. 

C# is a strongly typed language. Every variable and constant has a type, as does every expression that evaluates to a value. Every method declaration specifies a name, the type and kind (value, reference, or output) for each input parameter and for the return value. The .NET class library defines built-in numeric types and complex types that represent a wide variety of constructs. These include the file system, network connections, collections and arrays of objects, and dates. A typical C# program uses types from the class library and user-defined types that model the concepts that are specific to the program's problem domain.

The information stored in a type can include the following items:
- The storage space that a variable of the type requires.
- The maximum and minimum values that it can represent.
- The members (methods, fields, events, and so on) that it contains.
- The base type it inherits from.
- The interface(s) it implements.
- The kinds of operations that are permitted.
- The compiler uses type information to make sure all operations that are performed in your code are type safe.

## Refactoring and Unit testing

Code refactoring is the process of restructuring existing computer code—changing the factoring—without changing its external behavior. Refactoring is intended to improve the design, structure, and/or implementation of the software (its non-functional attributes), while preserving its functionality. Potential advantages of refactoring may include improved code readability and reduced complexity; these can improve the source code's maintainability and create a simpler, cleaner, or more expressive internal architecture or object model to improve extensibility.

Unit testing is a software testing method by which individual units of source code—sets of one or more computer program modules together with associated control data, usage procedures, and operating procedures—are tested to determine whether they are fit for use.

## Test-fist development

Test-first development is a software development process relying on software requirements being converted to test cases before software is fully developed, and tracking all software development by repeatedly testing the software against all test cases

## Operators and Control Flow

Operators are used to perform operations on variables and values. Types of operators by precedence are:

- Primary(x++, x [], x.y)
- Unary(+x, ++x, !x)
- Multiplicative(x*y, x/y, x%y)
- Additive
- Relational and type testing
- Equality
- Logical
- Conditional
- Assignment

Give an example of a ternary operator?

A). ?:

What does the modulus operator do?

 A). Returns remainder

What is the result of dividing integers 10 by 4?

A). 2

How would you calculate the number of weeks and days in 34 days?

A). weeks = 34/7 and days = 34%7

What is the difference between a postfix and a prefix increment operator?

A). The post-increment operator first, returns the variable’s original value, and afterward, increments the variable’s value by 1.Whereas the prefix operator will first increment the variable’s value by one and afterward, it will return the incremented value.

What is the difference between a unary and binary operator?

A). A binary operators has 2 operands and an unary has one.

Which types of operator have the lowest priority?

A). Assignment.

What are the 4 types of loop (just name them) 

- Do while
- for
- for each
- while
 Control flow is the order in which individual statements, instructions or function calls of a program are executed or evaluated.

 ## Exceptions

 What is an exception?

 A). Exception is an unwanted or unexpected event, which occurs during the execution of a program, i.e. at run time, that disrupts the normal flow of the program’s instructions. Exceptions can be caught and handled by the program. When an exception occurs within a method, it creates an object. This object is called the exception object. It contains information about the exception, such as the name and description of the exception and the state of the program when the exception occurred.

 Errors mostly occur at runtime that's they belong to an unchecked type. 

 What is the difference between an exception and other types of errors?

A). Exceptions are the problems which can occur at runtime and compile time. It mainly occurs in the code written by the developers.  Exceptions are divided into two categories such as checked exceptions and unchecked exceptions. 

How would you use a try-catch block when handling exceptions?
In handling exceptions, when is the finally block run?
