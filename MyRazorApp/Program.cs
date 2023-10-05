var builder = WebApplication.CreateBuilder(args);

//adiciona suporte a paginas razor
builder.Services.AddRazorPages();

var app = builder.Build();

//retirado endpoint
//app.MapGet("/", () => "Hello World!");


//configurações para a app ficar acessivel via browser
//UseStaticFiles leitura do wwwroot
//UseStaticFiles arquivos estaticos (cs, img, json, etc)
app.UseHttpsRedirection();
app.UseStaticFiles();

//auxiliar no mapeamento das paginas
app.UseRouting();
app.MapRazorPages();

app.Run();
