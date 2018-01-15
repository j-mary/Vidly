namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [Phone], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1707bd75-ddc4-4df9-9d5d-63a33f0df974', N'guest@vidly.com', 0, N'AHB/SqyWLLed1/lWkINXrpfloxE23jhNG8pkvJkU9CuHTl+nV2tRgrEgjQwdKFZtPw==', N'fc30979c-62e3-4026-9383-21a2388df3d7', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [Phone], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dcf5685c-e7eb-43dc-84c7-756d20032cdf', N'admin@vidly.com', 0, N'AF1HIrvWlMjBrWcMGZaITpoUPkCu2ResnhtNAP4BX8jzgu+77P4Q0VrUBl4phy4IdA==', N'b49ab522-4ac2-41bf-a231-0a5582995f03', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7a33c513-8c39-4253-a680-e77372189ff6', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dcf5685c-e7eb-43dc-84c7-756d20032cdf', N'7a33c513-8c39-4253-a680-e77372189ff6')
");
        }
        
        public override void Down()
        {
        }
    }
}
