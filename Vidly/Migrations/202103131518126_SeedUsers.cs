namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'65219bd4-747b-4c04-bcbb-78fd70994c7d', N'admin@vidly.com', 0, N'AHilpZubth5VPLKVerZMC3MjqI33SOSuDiVVQOYIFbdKzK8Arozi8YrhefdOTwopmg==', N'3a65f41b-0e81-4cba-82a0-04445f02267e', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'affa0e37-acc7-492b-817e-45476c3babe5', N'guest@vidly.com', 0, N'AFyvCcqT6wMUnStmM4qHy0JBFdRROcwW1QdOXfptvjP75h/3S/mW7qb7xUzhwYe0MA==', N'7c1e82da-4825-4e68-aa7a-7ed63bd3ced1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'38f85bd0-8982-4475-9b25-1649f9c0caff', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'65219bd4-747b-4c04-bcbb-78fd70994c7d', N'38f85bd0-8982-4475-9b25-1649f9c0caff')");
            
        }
        
        
        public override void Down()
        {
        }
    }
}
