# Mojishu

## Related Projects
- [NMeCab](https://github.com/egon-r/NMeCab)
- [Kawazu](https://github.com/egon-r/Kawazu)
- [mojishu-kanji-data](https://github.com/egon-r/mojishu-kanji-data)


## Build Dependencies
Mojishu relies on modified versions of [NMeCab](https://github.com/egon-r/NMeCab) and [Kawazu](https://github.com/egon-r/Kawazu) to translate from Kana to Romaji. Unity doesn't really support nuget packages so there is a `nuget-project` folder which is just an empty .NET project with an `AfterBuild` target in the csproj file that copies the output (managed .dll files) to `Assets/Shared/Resources` where Unity picks them up as plugins.

Since the modified nuget packages are not available on nuget.org a different feed has to be used. The easiest way is to set up a local feed by editing `NuGet.config`:
```
<configuration>
  <packageSources>
    ...
    <add key="Local Nuget Packages" value="E:\path\to\LocalNugetPackages" />
```
and place the .nupkg files in that folder. 

## Build Order
1. LibNMeCab
```
cd ./src/LibNMeCab
dotnet restore
dotnet build --configuration Release
nuget pack -Properties Configuration=Release -Version 0.10.3
```

2. Kawazu
```
cd ./Kawazu
dotnet restore
dotnet build --configuration Release
```

3. nuget-project

4. Mojishu