# Playwright for dotnet Demo with Specflow

## Summary

Sample UI automation project using Playwright, Specflow, .Net and C#

Using Github Actions for Continuous Integration.

Playwright dotnet: https://playwright.dev/dotnet/

## Repoistory Ownership

| Team | Contact Person |
| ---- | ------------------------------------|
Team| Ian O'Flynn|

## Dev Instructions

Once this project has been cloned the dependencies will need to be downloaded by executing this command in the project root:

```bash
dotnet restore
```

Update the following in `appsettings`

- url - Application Url to run tests against

Ensure the proper browser drivers(s) is(are) downloaded locally: see below.

Build the tests project

```bash
dotnet build
```

Run the tests by executing:

```bash
dotnet test
```

## implementation Guidelines

#### Automation Coding Standards

1. PageObject Models should be implemented by following of KISS, YAGNI and DRY principles
2. Classes, Methods, Fields, Constants and Properties should be named by following C# Naming Conventions
``` C#
/// <Summary>
/// Use camel-case style for Class/Interface Name
/// </summary>
public class Example
{

}

public interface IExample
{

}
```

