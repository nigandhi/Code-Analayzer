# Code-Analayzer
Code Analyzer for C# source code files.
The analyzer, given a set of file references, finds all the types, their members, and relationships with other types. Further, the analyzer constructs two metrics for each member function: its size in lines of code, and complexity defined as the number of elements in its scope tree.

Options Supported as Command Line Arguments
[/X] - Prints the result to an Xml file.
[/S] - Searches recursively inside a directory for all the files types specified in Command line argument (eg. *.cs)
[/R] - Displays relationship between all the files (Aggregation, Composition, Inheritence and Using)
