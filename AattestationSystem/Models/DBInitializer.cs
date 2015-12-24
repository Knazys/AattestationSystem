using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AattestationSystem.Models
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);

            context.Employees.Add(new Employee() { Name = "Альберт" });
            context.Employees.Add(new Employee() { Name = "Августин" });
            context.Employees.Add(new Employee() { Name = "Аркадий" });
            context.Employees.Add(new Employee() { Name = "Анатолий" });
            context.Employees.Add(new Employee() { Name = "Анастасия" });
            context.Employees.Add(new Employee() { Name = "Ануфрий" });
            context.Employees.Add(new Employee() { Name = "Арзамаз" });
            context.Employees.Add(new Employee() { Name = "Алешка" });
            context.Employees.Add(new Employee() { Name = "Алехандро" });
            context.Employees.Add(new Employee() { Name = "Арарат" });
            context.Employees.Add(new Employee() { Name = "Ананист" });
            context.Employees.Add(new Employee() { Name = "Анаталья" });
            context.Employees.Add(new Employee() { Name = "Аня" });
            context.Employees.Add(new Employee() { Name = "Антошка" });


            //// Дефолтный админ

            //var userManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            //var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            //// создаем две роли
            //var role1 = new IdentityRole { Name = "admin" };
            //var role2 = new IdentityRole { Name = "user" };

            //// добавляем роли в бд
            //roleManager.Create(role1);
            //roleManager.Create(role2);

            //// создаем пользователей
            //var admin = new ApplicationUser { Email = "somemail@mail.ru", UserName = "somemail@mail.ru" };
            //string password = "?FlvbyGbyudby!";
            //var result = userManager.Create(admin, password);

            //// если создание пользователя прошло успешно
            //if (result.Succeeded)
            //{
            //    // добавляем для пользователя роль
            //    userManager.AddToRole(admin.Id, role1.Name);
            //    userManager.AddToRole(admin.Id, role2.Name);
            //}


            context.SaveChanges();
        }
    }
}