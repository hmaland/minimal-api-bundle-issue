# minimal-api-bundle-issue
Demonstrate issue with running **dotnet ef migrations bundle** when nuget package Swashbuckle.AspNetCore is installed

Tech stack used:
- Windows 10 Pro
- Visual Studio Professional 2022 Preview (64-bit) (Preview 5)
- dotnet-ef tools version 6.0.0-rc.2.21480.5

Running **dotnet ef migrations bundle** fails when SwashBuckle.AspNetCore nuget package is installed.

Here is complete output:

```bash
C:\src\minimal-api-bundle-issue>dotnet ef migrations bundle --project MigrationsBundle --verbose
Using project 'C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj'.
Using startup project 'C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj'.
Writing 'C:\src\minimal-api-bundle-issue\MigrationsBundle\obj\MigrationsBundle.csproj.EntityFrameworkCore.targets'...
dotnet msbuild /target:GetEFProjectMetadata /property:EFProjectMetadataFile=C:\Users\john.doe\AppData\Local\Temp\tmp34FA.tmp /verbosity:quiet /nologo C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj
Writing 'C:\src\minimal-api-bundle-issue\MigrationsBundle\obj\MigrationsBundle.csproj.EntityFrameworkCore.targets'...
dotnet msbuild /target:GetEFProjectMetadata /property:EFProjectMetadataFile=C:\Users\john.doe\AppData\Local\Temp\tmp37AA.tmp /verbosity:quiet /nologo C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj
Build started...
dotnet build C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj /verbosity:quiet /nologo
C:\src\minimal-api-bundle-issue\MigrationsBundle\Program.cs(44,72): warning CS8632: The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]

Build succeeded.

C:\src\minimal-api-bundle-issue\MigrationsBundle\Program.cs(44,72): warning CS8632: The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
    1 Warning(s)
    0 Error(s)

Time Elapsed 00:00:01.91
Build succeeded.
dotnet exec --depsfile C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.deps.json --additionalprobingpath C:\Users\john.doe\.nuget\packages --additionalprobingpath "C:\Program Files\dotnet\sdk\NuGetFallbackFolder" --runtimeconfig C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.runtimeconfig.json C:\Users\john.doe\.dotnet\tools\.store\dotnet-ef\6.0.0-rc.2.21480.5\dotnet-ef\6.0.0-rc.2.21480.5\tools\netcoreapp3.1\any\tools\netcoreapp2.0\any\ef.dll migrations bundle --assembly C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll --project C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj --startup-assembly C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll --startup-project C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj --project-dir C:\src\minimal-api-bundle-issue\MigrationsBundle\ --root-namespace MigrationsBundle --language C# --framework net6.0 --working-dir C:\src\minimal-api-bundle-issue --verbose
Using assembly 'MigrationsBundle'.
Using startup assembly 'MigrationsBundle'.
Using application base 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0'.
Using working directory 'C:\src\minimal-api-bundle-issue\MigrationsBundle'.
Using root namespace 'MigrationsBundle'.
Using project directory 'C:\src\minimal-api-bundle-issue\MigrationsBundle\'.
Remaining arguments: .
Finding DbContext classes...
Finding IDesignTimeDbContextFactory implementations...
Finding application service provider in assembly 'MigrationsBundle'...
Finding Microsoft.Extensions.Hosting service provider...
Using environment 'Development'.
Using application service provider from Microsoft.Extensions.Hosting.
Found DbContext 'TodoDbContext'.
Finding DbContext classes in the project...
Using context 'TodoDbContext'.
info: Microsoft.EntityFrameworkCore.Infrastructure[10403]
      Entity Framework Core 6.0.0-rc.2.21480.5 initialized 'TodoDbContext' using provider 'Microsoft.EntityFrameworkCore.SqlServer:6.0.0-rc.2.21480.5' with options: None
Building bundle...
dotnet publish --runtime win10-x64 --output C:\Users\john.doe\AppData\Local\Temp\wgplkp1v.v5k\publish --no-self-contained
Microsoft (R) Build Engine version 17.0.0-preview-21501-01+bbcce1dff for .NET
Copyright (C) Microsoft Corporation. All rights reserved.

  Determining projects to restore...
  Restored C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj (in 413 ms).
  Restored C:\Users\john.doe\AppData\Local\Temp\wgplkp1v.v5k\efbundle.csproj (in 413 ms).
  You are using a preview version of .NET. See: https://aka.ms/dotnet-core-preview
C:\src\minimal-api-bundle-issue\MigrationsBundle\Program.cs(44,72): warning CS8632: The annotation for nullable reference types should only be used in code within a '#nullable' annotations context. [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): warning MSB3026: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Beginning retry 1 in 1000ms. The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): warning MSB3026: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Beginning retry 2 in 1000ms. The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): warning MSB3026: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Beginning retry 3 in 1000ms. The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): warning MSB3026: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Beginning retry 4 in 1000ms. The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): warning MSB3026: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Beginning retry 5 in 1000ms. The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): warning MSB3026: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Beginning retry 6 in 1000ms. The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): warning MSB3026: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Beginning retry 7 in 1000ms. The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): warning MSB3026: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Beginning retry 8 in 1000ms. The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): warning MSB3026: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Beginning retry 9 in 1000ms. The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): warning MSB3026: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Beginning retry 10 in 1000ms. The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): error MSB3027: Could not copy "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". Exceeded retry count of 10. Failed.  [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
C:\Program Files\dotnet\sdk\6.0.100-rc.2.21505.57\Microsoft.Common.CurrentVersion.targets(4635,5): error MSB3021: Unable to copy file "obj\Debug\net6.0\MigrationsBundle.dll" to "bin\Debug\net6.0\MigrationsBundle.dll". The process cannot access the file 'C:\src\minimal-api-bundle-issue\MigrationsBundle\bin\Debug\net6.0\MigrationsBundle.dll' because it is being used by another process. [C:\src\minimal-api-bundle-issue\MigrationsBundle\MigrationsBundle.csproj]
Microsoft.EntityFrameworkCore.Tools.CommandException: Build failed. Use --verbose to see errors.
   at Microsoft.EntityFrameworkCore.Tools.Commands.MigrationsBundleCommand.Execute(String[] args)
   at Microsoft.EntityFrameworkCore.Tools.Commands.CommandBase.<>c__DisplayClass0_0.<Configure>b__0(String[] args)
   at Microsoft.DotNet.Cli.CommandLine.CommandLineApplication.Execute(String[] args)
   at Microsoft.EntityFrameworkCore.Tools.Program.Main(String[] args)
Build failed. Use --verbose to see errors.
```
