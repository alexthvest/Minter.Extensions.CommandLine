using System;
using Minter.Extensions.CommandLine;

return new CommandLineProgramBuilder()
    .SetName("minter")
    .SetDescription("Minter Server CLI tool")
    .SetVersion(new Version(0, 0, 1))
    .Build()
    .Execute(args);