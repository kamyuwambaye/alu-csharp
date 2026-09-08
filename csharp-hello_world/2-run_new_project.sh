#!/usr/bin/env bash
rm -rf 2-new_project
dotnet new console -o 2-new_project
echo 'Console.WriteLine("Hello World!");' > 2-new_project/Program.cs
dotnet build 2-new_project
dotnet run --project 2-new_project
