namespace MovieRentalV04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'583f2540-ce6c-4a88-974f-0880af57a110', N'admin1@vidly.com', 0, N'AEvhj/iIpTk+EfogyOQav2dQyhZm3r3GbM+GfqOPaPNZFt/sQ1mpualvDIKQXhbxcA==', N'3eb1bc88-83c8-4e54-af54-0990fabddd17', NULL, 0, 0, NULL, 1, 0, N'admin1@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'820c541a-905d-48b0-8ced-ada83ee6391a', N'guest@vidly.com', 0, N'ACJrQ3W9N/zSu4QqWelHqgSQul0XZMDjAQ4mBNb7LE5UueeK4YwF2L+6JM/pDWq9Sg==', N'721bbbf8-2481-499b-bec4-2b658536cc6c', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'98c81af8-f663-4fe0-accc-404486a05056', N'admin3@vidly.com', 0, N'AJodNNqYcGUTyuD7xq4xY4vFBBo9JT9SOVuXb47GGgU5DFIjbdsFNZLnfa/qQ3WIpQ==', N'51731084-9ad1-412a-91d7-71505c3384ef', NULL, 0, 0, NULL, 1, 0, N'admin3@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f1830922-2b68-4fb4-beb9-f62ae8715f35', N'admin@vidly.com', 0, N'AEAAoZtqw6NQntpuwPT1Wu69G6/YzYkWQa8p+YKCfiG9eSBsjwBs8yxf6uxqhoCb/g==', N'aef005a2-182f-41f2-98b6-90b4ce071566', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5fd933d8-86e8-4791-b8b6-bf7250ec26b8', N'CanManageMovies')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e7bc3979-15ad-4177-95ec-681e23ee23d4', N'CanManagerMovie')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'98c81af8-f663-4fe0-accc-404486a05056', N'5fd933d8-86e8-4791-b8b6-bf7250ec26b8')


");
        }
        
        public override void Down()
        {
        }
    }
}
