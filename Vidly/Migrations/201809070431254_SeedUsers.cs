namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'65d54308-c13c-4dd4-9619-f0c6ab5ccfdb', N'guest@vidly.com', 0, N'AHYtxG/k8jUuEN0gSYWv3i+eMbksc2Zvd5wW+MN+J0HOIzko3HcLP1jBIwqMeRAeCA==', N'9b9e5f7f-8224-416d-94aa-79861cf53ea1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a239bee7-8770-45d8-a1c9-79dbae2d31af', N'admin@vidly.com', 0, N'ACvlfAEswcWIJX7A55zj2jHjugiDHOIjENqwIj2s7rIX8J1gUflLdYdmYra5WPgD/g==', N'ceb716fd-d218-4f8d-bbea-33abe5a0ad79', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c2f19d50-acfb-4aca-b6c9-1d823f951ad4', N'CanManageMovie')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a239bee7-8770-45d8-a1c9-79dbae2d31af', N'c2f19d50-acfb-4aca-b6c9-1d823f951ad4')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
