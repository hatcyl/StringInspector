String Inspector

Usage
- The Solution includes a console application. Running it will cause it to prompt for a string and output the characters that occur the most.
- StringInspector.Core is the library with the functionality. The library can be used to find the characters that occur the most in code.
- StringInspector.Test has a few test cases which test teh correcness of the StringInspector.Core library.

Thought Process
- Soltuion Structure: Should always seperate UI code from any other reusable code. This allows teh reusable code to be tested.
- StringInspector: Without using LINQ, iterate each character in a string and keep track of how many times it occurs. Keep track of the maximum number of times any one charcter occurs, this makes it easy to find all teh most occuring ones at the end.