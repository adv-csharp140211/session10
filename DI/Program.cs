using DI.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

//builder.Services.AddTransient<IMyLog, MyLogDB>(); // new object every time
builder.Services.AddScoped<IMyLog, MyLogDB>(); // for each request, only one instance
//builder.Services.AddSingleton<IMyLog, MyLogDB>(); // only one instance all the time


builder.Services.AddTransient<UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
