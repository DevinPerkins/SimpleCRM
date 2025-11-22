using Microsoft.EntityFrameworkCore;
using SimpleCRM.Data;

var builder = WebApplication.CreateBuilder(args);

// Register MVC (controllers + views)
builder.Services.AddControllersWithViews();

// Register our DbContext with SQLite
builder.Services.AddDbContext<CrmContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Enable attribute-routed controllers
app.MapControllers();

// Optional: simple test endpoint to confirm app responds
app.MapGet("/test", () => "Hello from /test");

app.Run();


