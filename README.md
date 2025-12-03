# Bin2Dec

A small .NET console tool that converts an 8-bit binary number to its decimal representation.

## 🔧 Project overview

- Language: C#
- Target framework: .NET 10 (net10.0)
- Project type: Console application

The program reads a binary number (up to 8 digits) from STDIN and prints its decimal equivalent. Enter `q` to quit the interactive program.

## ▶️ Build and run

Requirements:
- .NET SDK 10 or newer installed (dotnet command available).

From the repository root you can build and run the app with the following commands:

```powershell
# build
dotnet build

# run from the project folder
dotnet run --project ./Bin2Dec
```

If you prefer to run the compiled executable directly (after building) you can find it under `bin/Debug/net10.0/`.

## 🧭 Usage

Start the program and enter binary numbers (max 8 bits). The program validates input and prints the decimal value.

Example interactive session:

```
Enter 'q' to quite the program
Enter a binary number up to 8 digits: 10110010
Your decimal number is: 178
Enter a binary number up to 8 digits: 0101
Your decimal number is: 5
Enter a binary number up to 8 digits: q
```

Notes:
- The program allows up to 8 binary digits (0/1). Any input longer than 8 characters or containing characters other than 0/1 triggers an error message and prompts again.
- Input `q` quits the program.