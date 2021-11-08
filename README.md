# dotnet_test_template

steps to create this app
1. create new solution

dotnet new sln -n helloWorld

2. create new app

dotnet new console -n helloWorldApp

3. attach the project to solution

dotnet sln add helloWorldApp

4. test run the hello world app

dotnet restore .

dotnet build .

dotnet run --project helloWorldApp

5. Create a new Nunit test project and add it to solution

dotnet new nunit -n helloWorldAppTest

dotnet sln add helloWorldAppTest

6. Test the successfull creation of test app

dotnet test

7. Add helloWorld reference to test project

dotnet add helloWorldAppTest reference helloWorldApp

8. Create a new function in helloWorldApp and unit test it with test project