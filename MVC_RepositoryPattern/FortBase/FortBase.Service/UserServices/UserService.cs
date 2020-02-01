using AutoMapper;
using FortBase.Common;
using FortBase.Common.Messages;
using FortBase.Repository.Contracts.UserContracts;
using FortBase.Repository.Models.UserModels;
using FortBase.Service.Contracts.UserContracts;
using FortBase.Service.Models.UserViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FortBase.Service.UserServices
{
    public class UserService : IUserService
    {
        private readonly IMapper mapper;
        private IUserRepository userRepository;

        public UserService(
            IMapper mapper,
            IUserRepository userRepository)
        {
            this.mapper = mapper;
            this.userRepository = userRepository;
        }

        public ResultObject GetUsers()
        {
            UserMessages message;
            string messageText = null;
            List<UserVM> users = null;
            try
            {
                users = mapper.Map<List<UserVM>>(userRepository.FindAll());
                message = UserMessages.UsersRetrieved;
            }
            catch (Exception ex)
            {
                message = UserMessages.ErrorUsersRetrieved;
                messageText = ex.Message;
            }

            return new ResultObject
            {
                Result = users,
                Message = (int)message,
                MessageText = messageText
            };
        }
    

        public ResultObject SaveUser(UserVM userVM)
        {
            UserMessages message;
            string messageText = null;
            try
            {
                if (userVM != null)
                {
                    var user = mapper.Map<User>(userVM);
                    userRepository.Create(user);
                    userRepository.Save();
                    message = UserMessages.UserSaved;
                }
                else
                {
                    message = UserMessages.UserNotSaved;
                }
            }
            catch (Exception ex)
            {
                message = UserMessages.ErrorSaveUser;
                messageText = ex.Message;
            }

            var result = new ResultObject
            {
                Message = (int)message,
                MessageText = messageText,
                Result = userVM
            };
            return result;
        }
    }
}
