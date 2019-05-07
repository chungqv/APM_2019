namespace APM.Data.Migrations
{
    using APM.Common;
    using APM.Entity.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<APM.Data.APMDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(APM.Data.APMDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            CreateUser(context);
        }
        private void CreateUser(APMDBContext context)
        {
            context.AppGroups.Add(new AppGroup { ID = 1, Description = "Quan tri he thong" });

            context.AppRoles.Add(new AppRole { ID = 1, Description = "Admin" });
            context.AppRoles.Add(new AppRole { ID = 2, Description = "User" });
            context.AppRoles.Add(new AppRole { ID = 3, Description = "Member" });

            context.AppRoleGroups.Add(new AppRoleGroup { RoleID = 1, GroupID = 1 });
            context.AppRoleGroups.Add(new AppRoleGroup { RoleID = 2, GroupID = 1 });

            context.AppUser.Add(new AppUser()
            {
                UserName = "admin",
                Email = "chungquachvan@gmail.com",
                Sex = true,
                BirthDay = DateTime.Now,
                FullName = "apple family",
                PassWord = Security.Encipt("admin"),
                PhoneNumber = "0982511597"

            });

            context.AppUserGroups.Add(new AppUserGroup { UserName = "admin", GroupID = 1 });

        }
    }
}
