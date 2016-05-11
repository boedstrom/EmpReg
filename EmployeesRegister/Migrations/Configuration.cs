namespace EmployeesRegister.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Models;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeesRegister.DataAccessLayer.EmployeesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(EmployeesRegister.DataAccessLayer.EmployeesContext context)
        {
            context.Companies.AddOrUpdate(r => r.Name,
                new Company { Name = "Mucho Stuff"},
                new Company { Name = "Banana INC" },
                new Company { Name = "F:a Ruffel & Båg" });

            //  This method will be called after migrating to the latest version.
            context.Employees.AddOrUpdate(r => r.FirstName,
                new Employee { FirstName = "Emil", LastName = "Kork", Salary = 40000, Position = "Salesman", Department = "Sport", Company = "Mucho Stuff" },
                new Employee { FirstName = "Frollo", LastName = "Svedin", Salary = 10000, Position = "Janitor", Department = "Maintenance", Company = "Mucho Stuff" },
                new Employee { FirstName = "Kurt", LastName = "Roddjur", Salary = 35000, Position = "Salesman", Department = "Men's Clothes", Company = "Mucho Stuff" });
        }
    }
}
