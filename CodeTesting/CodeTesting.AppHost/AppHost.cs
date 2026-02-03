var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.CodeTesting>("codetesting");

builder.Build().Run();
