all : buildz

clean:
	dotnet clean
	rm -rf bin/

buildz: 
	dotnet build --configuration Release --output bin/ --nologo fs.sln

step0_repl.exe: buildz
