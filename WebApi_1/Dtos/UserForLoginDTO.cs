namespace WebApi_1.Dtos
{
    public class UserForLoginDTO
    {
        private string _userName;

        public string Username { get {return _userName.ToLower(); } set { _userName = value; } }

        public string Password { get; set; }
    }
}