build: directory hello.exe

hello.exe: hello.cs
	csc -debug hello.cs /out:bin\hello.exe

clean:
	del bin\hello.exe bin\hello.pdb

rebuild: clean build

directory: bin

bin:
	md bin