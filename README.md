1. dotnet new webapi --name "Products.Api" --framework "net9.0" -controllers true

2. dotnet new classlib --name "Products.Infrastructure" --framework "net9.0"

3. dotnet new classlib --name "Products.Service" --framework "net9.0"

4. dotnet new xunit --name "Products.Api.Test" --framework "net9.0"

5. dotnet add Products.Api package Swashbuckle.AspNetCore

6. dotnet run --project Products.Api/Products.Api.csproj

7. dotnet tool install --global Coverlet.Console

8. dotnet test --collect:"XPlat Code Coverage"

9. dotnet tool install --global dotnet-reportgenerator-globaltool

10. reportgenerator -reports:"**/coverage.cobertura.xml" -targetdir:"coverage-report" -reporttypes:Html
