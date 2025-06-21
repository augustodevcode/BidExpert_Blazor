var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.BidExpert_Blazor_ApiService>("apiservice");

builder.AddProject<Projects.BidExpert_Blazor_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
