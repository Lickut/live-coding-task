# live-coding-task

### Prerequisities
1. [git](https://git-scm.com/)
2. [dotnet 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
3. [Chrome](https://www.google.com/chrome/) (v.103.0)
4. Any IDE of your choice

### Description

##### UI tests
- Tests are written using _Selenium Webdriver_ web framework for Chrome browser
- Tests are located in _LiveCodingUi_ test project
- NUnit is used as test runner
- Website https://www.saucedemo.com is used as system under test

##### API tests
- Tests are written using RestSharp library
- Tests are located in _LiveCodingApi_ test project
- NUnit is used as test runner.
- Public API https://catfact.ninja is used as system under test

##### How to run tests
Clone repository and run next commands:
```
dotnet build .\LiveCodingUi\LiveCodingUi.csproj
pwsh .\LiveCodingUi\bin\Debug\net6.0\playwright.ps1 install chrome
dotnet test .\LiveCodingApi\LiveCodingApi.csproj
dotnet test .\LiveCodingUi\LiveCodingUi.csproj
```
