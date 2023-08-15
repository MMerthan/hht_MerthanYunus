using FluentValidation.AspNetCore;
using MakineBussines.Helpers.Images;
using MakineBussines.Services.Abstractions;
using MakineBussines.Services.concretes;
using MakineData.Context;
using MakineData.Repositories.Abstractions;
using MakineData.Repositories.Concretes;
using MakineEntity.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using NToastNotify;
using System.Globalization;
using static MakineBussines.RolesAndPolices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSession();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddEntityFrameworkSqlServer();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IImageHelper, ImageHelper>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
	opt.Password.RequireNonAlphanumeric = false;
	opt.Password.RequireLowercase = false;
	opt.Password.RequireUppercase = false;
})
	.AddRoleManager<RoleManager<AppRole>>()
	.AddSignInManager<SignInManager<AppUser>>()
	.AddEntityFrameworkStores<AppDbContext>()
	.AddDefaultTokenProviders();

builder.Services.AddMvc(config =>
{
	var policy = new AuthorizationPolicyBuilder()
		.RequireAuthenticatedUser()
		.Build();
	config.Filters.Add(new AuthorizeFilter(policy));
})
.AddFluentValidation(opt =>
{
	opt.RegisterValidatorsFromAssemblyContaining<UserValidator<AppUser>>();
	opt.DisableDataAnnotationsValidation = true;
	opt.ValidatorOptions.LanguageManager.Culture = new CultureInfo("tr");
})
 .AddNToastNotifyToastr(new ToastrOptions()
 {
	 PositionClass = ToastPositions.TopRight,
	 TimeOut = 3000,
 })
.AddRazorRuntimeCompilation();

builder.Services.AddAuthorization(options =>
{
	options.AddPolicy(Policies.AdminOnly, policy => policy.RequireRole(Roles.Superadmin));
});


builder.Services.ConfigureApplicationCookie(opt =>
{
	opt.LoginPath = new PathString("/Account/Login");
	opt.Cookie.HttpOnly = true;
	opt.ExpireTimeSpan = TimeSpan.FromMinutes(30);
	opt.Cookie.Name = "authCookie";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.UseNToastNotify();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
		name: "default",
		pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
