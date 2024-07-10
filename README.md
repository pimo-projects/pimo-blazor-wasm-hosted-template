# PIMO Blazor WebAssembly Hosted Project Template

A project template for hosted Blazor WebAssembly project for .NET 8.

- Uses minimal APIs by default
- Adds Serilog
- Adds Swagger and SwaggerUI

## How to install

```bash
dotnet new install taotiato
```

## How to create a project

```bash
dotnet new pimo-blazorwasm-hosted # default (use the name of the current working directory/folder)

dotnet new pimo-blazorwasm-hosted --name <YourProjectName> # specify your project name

dotnet new pimo-blazorwasm-hosted --name <YourProjectName> --UseController # to use controllers instead of minimal APIs
```

