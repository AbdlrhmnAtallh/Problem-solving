# Generate Random Passwords

This project allows you to generate random numbers and random strings based on user-defined criteria.


## Options

The program offers the following options:

1. Generate Random Number: Allows you to input minimum and maximum values to generate a random number within that range.

2. Generate Random String: Enables you to specify the length and character types for generating a random string.

## Generate Random Number

To generate a random number, follow these steps:

1. Select option 1 when prompted.
2. Enter the minimum and maximum values for the desired range.
3. The program will generate and display a random number within the specified range.

## Generate Random String

To generate a random string, follow these steps:

1. Select option 2 when prompted.
2. Enter the desired length for the random string.
3. Answer the subsequent prompts regarding the inclusion of capital letters, small letters, symbols, and numbers.
4. The program will generate and display a random string based on the specified criteria.

### Constants

The program uses the following constants:

- `CapitalString`: A string containing capital letters (ABCDEFGHKLMNOPQRSTUVWYXZ).
- `SmallString`: A string containing small letters (abcdefghklmnopqrstuvwyxz).
- `SymbolsString`: A string containing symbols (+-_*&$#@).
- `NumbersString`: A string containing numbers (0123456789).

## Limitations

- The program expects valid numeric input for the minimum and maximum values when generating a random number. Non-numeric inputs will result in an error.
- The program requires valid numeric input for the string length when generating a random string. Non-numeric inputs will result in an error.

