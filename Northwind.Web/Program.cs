//var builder = WebApplication.CreateBuilder(args);
//var app = builder.Build();

//app.UseHttpsRedirection();
//app.MapGet("/", () => "Hello World!");

//app.Run();

//Console.WriteLine("This executes after the web server has stopped!");

//if (!app.Environment.IsDevelopment())
//{
//    app.UseHsts();
//}

using Northwind.Web; // Startup

Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
                                                        {
                                                            webBuilder.UseStartup<Startup>();
                                                        }).Build().Run();
Console.WriteLine("This executes after the web server has stopped!");