namespace DevFreela.API.Models
{
    public class CreateUserInputModel
    {
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
