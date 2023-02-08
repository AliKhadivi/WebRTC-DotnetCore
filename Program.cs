using Microsoft.AspNetCore.Builder;
using webrtc_dotnetcore.Hubs;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

Console.WriteLine("------------------------------------");
Console.WriteLine("| App Started!                     |");
Console.WriteLine("| Project Name: Dotnet Core WebRTC |");
Console.WriteLine("| Powered by Ali Khadivi           |");
Console.WriteLine("------------------------------------");
Console.WriteLine(" -> Logs:");
var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

builder.Services.AddSignalR();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.MapHub<WebRTCHub>("/WebRTCHub");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
//app.UseMvc(routes =>
//{
//    routes.MapRoute(
//        name: "default",
//        template: "{controller=Home}/{action=Index}/{id?}");
//});
app.Run();

Console.WriteLine("------------------------------------");
Console.WriteLine("| App Stopped!  Bye!               |");
Console.WriteLine("| Project Name: Dotnet Core WebRTC |");
Console.WriteLine("| Powered by Ali Khadivi           |");
Console.WriteLine("------------------------------------");

