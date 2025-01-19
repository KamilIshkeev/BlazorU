namespace BlazorU.ApiRequest.Model
{
    public class UserDataShort
    {
        public int id_Email { get; set; }
        public int id_User { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Descrioption { get; set; }
        public string Role { get; set; }
    }

    public class UserData
    {
       public bool status { get; set; }
       public UserDataContainer data { get; set; }
    }

    public class UserDataContainer
    {
        public List<UserDataShort> users { get; set; }
    }

    public class ReqDataUser
    {
        public int id_Email { get; set; }
        public int id_User { get; set; }
        public string Name { get; set; }
        public string Descrioption { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }

    public class UserAddData
    {
        public bool status { get; set; }
    }
}
