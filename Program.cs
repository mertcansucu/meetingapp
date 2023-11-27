var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();//mvc şablonu eklemek için

//mvc
//rest api
//razor pages

var app = builder.Build();

app.UseStaticFiles();//wwwroot dosyalarının dışarıya aktif hale getirdim

app.UseRouting();

// app.MapGet("/", () => "Hello World!"); controller ile sayfalara erişim sağladığım için kontrolu burdan alıp controller a verdim
// app.MapGet("/abc", () => "Hello World!");

//{controller=Home}/{action=index}/id?    değişken=controller-değişken
//1. Yol alttaki kod ile diğer ypl ile de yapabilirim bunu
// app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
