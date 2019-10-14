using FortBase.Model;

namespace FortBase.Data
{
    public static class UserData
    {
        public static UserModel SaveUser(int id, string name)
        {
            var user = new UserModel
            {
                Id = id,
                Name = name
            };
            return user;
        }
    }
}
