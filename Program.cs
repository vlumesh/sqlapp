using sqlapp.Services;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "Endpoint=https://app-config-204.azconfig.io;Id=DRDj-l8-s0:Jn7DSG1+Uyyhl74Bi05e;Secret=BL7m8MUuJNhnw1A5/ZdnN0B1nau+rfnnOgaoCazFyVE=";
builder.Host.ConfigureAppConfiguration(builder =>
{
    builder.AddAzureAppConfiguration(connectionString);
});

builder.Services.AddTransient<IProductService, ProductService>();

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
