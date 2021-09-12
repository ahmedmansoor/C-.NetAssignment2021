
namespace AssignmentC
{
    class Login
    {
        public string email { get; set; }
        public string password { get; set; }

        public bool Validation(Login input)
        {
            if (input.email == "a" && input.password == "b")
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
