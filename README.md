# Mojishu

![mojishu1](https://github.com/egon-r/mojishu/assets/107209158/f01bb996-cc70-4fdc-b2ec-1fa9e2f74a23)
![mojishu2](https://github.com/egon-r/mojishu/assets/107209158/8a67a350-6f26-4cba-843f-c30e37cc329b)
![mojishu3](https://github.com/egon-r/mojishu/assets/107209158/cea431e4-137c-4bb2-b1b1-eec13726dbbd)

## Related Projects
- [NMeCab](https://github.com/egon-r/NMeCab)
- [Kawazu](https://github.com/egon-r/Kawazu)
- [mojishu-kanji-data](https://github.com/egon-r/mojishu-kanji-data)

# Build
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

# Text Rendering
Text is rendered using TextMeshPro which uses a texture atlas generated from a list of characters.
If a character is not rendered correctly it needs to be added to the character list and the texture atlast needs to be regenerated. Relevant files can be found in `Fonts/Japanese/`. Use the FontAssetCreator to generate a texture atlas `Window -> TextMeshPro -> FontAssetCreator`.

Try to keep the Atlast Resolution at 2048x2048 as higher resolutions can cause issues on mobile devices. Make sure to generate a texture atlas for every font used (XANO mincho, Noto Sans JP).
