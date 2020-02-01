using FortBase.Model;

namespace FortBase.Data
{
    public class UserData
    {
        private FortBaseDbContext dbContext;

        public UserData(FortBaseDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public UserModel SaveUser(string name)
        {
            try
            {
                var user = new UserModel
                {
                    Name = name
                };
                dbContext.Users.Add(user);
                dbContext.SaveChanges();

                return user;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
    }
}
