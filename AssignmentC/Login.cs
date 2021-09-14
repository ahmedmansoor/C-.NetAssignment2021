
namespace AssignmentC
{
    class Login
    {
        public string email { get; set; }
        public string password { get; set; }

        public bool Validation(Login input)
        {
            if (input.email == "admin" && input.password == "123")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
