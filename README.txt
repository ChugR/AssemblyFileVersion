AssemblyFileVersion is a tool to expose a .NET assembly's AssemblyVersion
number. This number is not the version number shown in Windows Explorer's 
file properties.

The assembly file path name is passed to this program as an argument:

  > assemblyfileversion mypath\myfile.dll
  
The program loads the assembly file in reflection-only mode and then prints
out the version information. Loading in reflection-only means that the file's
dependent libraries do not need to be resolved in order to see the simple
version number.
