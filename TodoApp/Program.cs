using TodoApp.Components;
using TodoApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();
builder.Services.AddSingleton<ITodoService, TodoService>();
builder.Services.AddScoped<MarkdownExporter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();
app.UseStaticFiles();

app.MapStaticAssets();
app.MapRazorComponents<App>();

app.Run();
