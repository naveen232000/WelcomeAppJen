// See https://aka.ms/new-console-template for more information
using WelcomeApp2;

Console.WriteLine("welcome to Authentication ");
SignIn signIn= new SignIn();

Console.WriteLine(signIn.Authentication("Admin", "Admin@123"));
