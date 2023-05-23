// See https://aka.ms/new-console-template for more information
// A list of the types of changes that you can make that support Hot Reload is found at the following link: https://aka.ms/dotnet/hot-reload.

/* Visual Studio: run the app, change the message, click Hot Reload
button.
 * Visual Studio Code: run the app using dotnet watch, change the
message. */

while (true)
{
    WriteLine("Goodbye, Hot Reload!");
    await Task.Delay(2000);
}