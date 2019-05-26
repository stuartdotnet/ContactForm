# ContactForm

## Installation
This is a .net core app with vanilla react front end. To run the code it should be a simple matter of cloning the project locally and running the main solution in Visual Studio, which will automatically download Nuget Packages and boostrap the react app.

## Running the app without Visual Studio
From the ContactForm folder, run the following commands:

- dotnet restore
- dotnet publish -c release -r win10-x64
- dotnet run

The site should run at http://localhost:5000. You may have to bypass the certificate warning.
