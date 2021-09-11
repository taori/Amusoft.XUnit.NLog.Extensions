$configuration = "Release"
$verbosity = "n"

dotnet restore ../src/All.sln --verbosity $verbosity
Write-Host "Restore complete" -ForegroundColor Green

dotnet build ../src/All.sln --verbosity $verbosity -c $configuration --no-restore
Write-Host "Build complete" -ForegroundColor Green

dotnet test ../src/All.sln --verbosity $verbosity -c $configuration --no-build 
Write-Host "Test complete" -ForegroundColor Green

dotnet pack ../src/Amusoft.XUnit.NLog.Extensions/Amusoft.XUnit.NLog.Extensions.csproj --verbosity $verbosity -c $configuration -o ../artifacts/nupkg --no-build /p:VersionSuffix=$versionSuffix -p:IncludeSymbols=true -p:SymbolPackageFormat=snupkg
