# Creat Solution references

dotnet add PizzaPro.Test/PizzaPro.Test.csproj reference PizzaPro.Domain/ 
dotnet add PizzaPro.Client/PizzaPro.Client.csproj reference PizzaPro.Domain/PizzaPro.Domain.csproj 
dotnet add PizzaPro.DataStore/PizzaPro.DataStore.csproj reference PizzaPro.Domain/PizzaPro.Domain.csproj 
dotnet add PizzaPro.Client/PizzaPro.Client.csproj reference PizzaPro.DataStore/PizzaPro.DataStore.csproj 

# Add Entity Framework Dependencis

dotnet add PizzaPro.DataStore/PizzaPro.DataStore.csproj package microsoft.entityframeworkcore.sqlserver
dotnet add PizzaPro.DataStore/PizzaPro.DataStore.csproj package microsoft.entityframeworkcore.design
dotnet add PizzaPro.Client/PizzaPro.Client.csproj package microsoft.entityframeworkcore.design

# Add the projects to the solution

dotnet sln add PizzaPro.Client/
dotnet sln add PizzaPro.Domain
dotnet sln add PizzaPro.Test
dotnet sln add PizzaPro.DataStore/
