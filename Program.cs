var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();       //? Suporte para Razor pages

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();                   //? Suporte para arquivos estaticos (wwwroot)

app.UseRouting();
app.MapRazorPages();

app.Run();