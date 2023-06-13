var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddTypes()
    .AddFiltering();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
