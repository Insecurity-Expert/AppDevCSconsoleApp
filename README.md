# HelloStudentApp

A simple C# console application for beginners. It:
- Asks the user for their name
- Asks for a student number (digits only)
- Prints a personalized greeting
- Displays the student’s info using a Student class

> Note about leading zeros: If you store student numbers as `int`, leading zeros (e.g., `02368`) won’t be preserved because integers don’t store formatting. To display leading zeros, either:
> - Format when printing: `student.StudentNumber.ToString("D5")` (for a fixed width like 5), or
> - Keep the raw input string (recommended if the format matters) and print that string.

## Prerequisites
- [.NET SDK 8.0+](https://dotnet.microsoft.com/download)

Verify install:
```bash
dotnet --version
```

## Getting Started

Clone your repository:
```bash
git clone https://github.com/<your-username>/HelloStudentApp.git
cd HelloStudentApp
```

Build and run:
```bash
dotnet build
dotnet run
```

## Usage

Example interaction:
```
Enter your name: Angel
Enter your student number (numbers only, e.g., 123456): 02368
Hello, Angel!
Student info:
Name: Angel
Student Number: 02368
```

## Project Structure
- `Program.cs`: Console input/output and basic validation.
- `Student.cs`: The `Student` class with `Name` (string) and `StudentNumber` (int).

## Troubleshooting
- “Cannot implicitly convert type 'string' to 'int'”:
  - Ensure `StudentNumber` is `int` in `Student.cs` and you assign an integer in `Program.cs`.
- “The type or namespace name 'Student' could not be found”:
  - Make sure `Student.cs` is in the same project folder and uses the same namespace (`HelloStudentApp`).
- `dotnet` not found:
  - Reopen terminal after installing .NET or ensure it’s on your PATH.

## License
Add a license if you plan to share or collaborate (e.g., MIT).
