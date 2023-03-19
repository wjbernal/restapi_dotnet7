/* 
  Here we have the builder variable which we can use
  fror dependency injection and configuration
*/

using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
{
  builder.Services.AddControllers();
  builder.Services.AddScoped<IBreakfastService, BreakfastService>(); 
}



/** From here we have the App variable
    in which we can manage the request pipeline
*/
var app = builder.Build();
{
  app.UseExceptionHandler("/error");
  app.UseHttpsRedirection();
  app.MapControllers();
  app.Run();
}

