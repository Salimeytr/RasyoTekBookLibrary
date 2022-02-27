using BookLibrary.Dal;
using BookLibrary.Repos.Abstract;
using BookLibrary.Repos.Concrete;
using BookLibrary.UI.Models.ViewModel;
using BookLibrary.UnitOfWork;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Context>(op => op.UseSqlServer(builder.Configuration.GetConnectionString("Baglanti")));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); //dependincy of injection //IUnitOfWork gördüðün yere UnitOfWork yerleþtir demektir.
builder.Services.AddScoped<BooksModel>();
builder.Services.AddScoped<IBookRepos, BookRepos>();
builder.Services.AddScoped<ICatRepos, CatRepos>();
builder.Services.AddScoped<IPubRepos, PubRepos>();
builder.Services.AddScoped<IWriterRepos, WriterRepos>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
