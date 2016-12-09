#! /bin/bash
rm -rf artefacts
mkdir artefacts
mkdir artefacts/lib
mkdir artefacts/lib/netstandard1.6
cd ./Source
dotnet build
cd ..
cp ./Source/bin/Debug/netstandard1.6/*.dll ./artefacts/lib/netstandard1.6
cp ./Source/bin/Debug/netstandard1.6/*.pdb ./artefacts/lib/netstandard1.6
cp ./Source/Package.nuspec ./artefacts
cd artefacts
nuget pack Package.nuspec -symbols -version 1.0.4
#-suffix nightly002 

#dotnet pack ./Source -c Release -o artefacts --version-suffix nightly001