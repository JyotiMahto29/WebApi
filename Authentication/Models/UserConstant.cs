namespace Authentication.Models
{
    public class UserConstant
    {
        public static List<UserModel> Users = new()
        {
           new UserModel(){ Username="jyoti",Password="jyoti_123",Role="Admin"}
        };
    }
}
