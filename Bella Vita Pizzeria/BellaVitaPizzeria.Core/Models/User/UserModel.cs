namespace BellaVitaPizzeria.Core.Models.User
{
    public class UserModel
    {
        public UserModel(
            string id,
            string username)
        {

            Id = id;
            Username = username;
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
    }
}
