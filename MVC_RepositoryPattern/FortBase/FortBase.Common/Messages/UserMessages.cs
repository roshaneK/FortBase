namespace FortBase.Common.Messages
{
    public enum UserMessages
    {
        //Success Messages : 1000 - 1999
        UserSaved = 1000,
        UsersRetrieved = 1001,
        NoUserAvailable = 1002,

        //Un-Success Messages : 2000 - 2999
        UserNotSaved = 2000,
        BusinessUserNotSaved = 2001,

        //Error Messages : 3000 - 3999
        ErrorSaveUser = 3000,
        ErrorSaveBusinessUser = 3001,
        ErrorUsersRetrieved = 3002
    }
}
