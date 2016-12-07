#! /bin/bash
rm -rf artefacts
mkdir artefacts
mkdir artefacts/lib
mkdir artefacts/lib/netcoreapp1.0
cd ./Source
dotnet build
cd ..
cp ./Source/bin/Debug/netcoreapp1.0/*.dll ./artefacts/lib/netcoreapp1.0
cp ./Source/bin/Debug/netcoreapp1.0/*.pdb ./artefacts/lib/netcoreapp1.0
cp ./Source/Package.nuspec ./artefacts
cd artefacts
nuget pack Package.nuspec -symbols -version 1.0.0 -suffix nightly001 

#dotnet pack ./Source -c Release -o artefacts --version-suffix nightly001