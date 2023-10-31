using Microsoft.AspNetCore.Identity;
using Task_Managment.Domain;


namespace Task_Managment.Infrastructure
{
    public class TestData
    {
        public static async System.Threading.Tasks.Task InsertData(DatabaseContext context, UserManager<User> userManager)
        {
            if (!userManager.Users.Any())
            {
                var userTest = new User
                {
                    Id = "9411b400-11c1-4c6b-82a3-a73dd8347b63",
                    UserName = "UserTest",
                    Email = "userTest@test.com",
                    PhoneNumberConfirmed = false,
                    EmailConfirmed = false,
                    TwoFactorEnabled = false,
                    LockoutEnabled = false,
                    AccessFailedCount = 0,
                    CreatedOn = DateTime.Now,
                    CreatedBy = "Sytem",
                    UpdateBy = "System",
                    UpdatedOn = DateTime.Now,

                };
                await userManager.CreateAsync(userTest, "Password123$");
            }

            if (!context.Category.Any())
            {
                var categories = new List<Category>
                {
                    new Category
                    {
                        CategoryId = new Guid("e83a4baf-e0db-48e7-a62e-8059572cf427"),
                        Name = "Trabajo",
                        CreatedOn = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedOn = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Category
                    {
                        CategoryId = new Guid("51f4776f-b23b-41f4-bab4-12e2a584e3bc"),
                        Name = "Personal",
                        CreatedOn = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedOn = DateTime.Now,
                        UpdatedBy = "System",
                    },
                    new Category
                    {
                        CategoryId = new Guid("41f9389e-5521-46ee-a142-669df7e7f1a7"),
                        Name = "Familia",
                        CreatedOn = DateTime.Now,
                        CreatedBy = "System",
                        UpdatedOn = DateTime.Now,
                        UpdatedBy = "System",
                    }
                };

                context.AddRange(categories);
                await context.SaveChangesAsync();
            }
        }

    }
}
