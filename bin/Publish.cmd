if exist "AnsiConsole\bin\Package\" rmdir /Q /S "AnsiConsole\bin\Package"
nuget pack "AnsiConsole\AnsiConsole.csproj" -OutputDirectory "AnsiConsole\bin\Package" -Build -Prop "Configuration=Release;Platform=AnyCPU"
nuget push "AnsiConsole\bin\Package\*.nupkg" -Source "https://www.nuget.org/api/v2/package" -NonInteractive
pause
