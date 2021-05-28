using System;
using Minter.Extensions.CommandLine;

var program = new CommandLineProgram(
    "minter", 
    "Minter Server CLI tool", 
    new Version(0, 0, 1));

return program.Execute(args);