using FortBase.Common;
using FortBase.Common.Enums;
using FortBase.Data;
using FortBase.Model;
using System;

namespace FortBase.Service
{
    public class UserService
    {
        public ResultObject SaveUser(UserModel userModel)
        {
            var result = new ResultObject();

            try
            {
                var user = UserData.SaveUser(userModel.Id, userModel.Name);
                if (user != null)
                {
                    result.Message = (int)Messages.UserSaved;
                    result.Result = user;
                }
                else
                {
                    result.Message = (int)Messages.UserNotSaved;
                }
            }
            catch (Exception ex)
            {
                result.Message = (int)Messages.ErrorSaveUser;
            }
            return result;
        }
    }
}
