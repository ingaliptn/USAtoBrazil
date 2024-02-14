namespace USAtoBrazil.Services.Identity.Models
{
    //public class UserModel
    //{
    //    public List<UserItem> List { get; set; } = new List<UserItem>();
    //}
    public class UserItem
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CEP { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CPF { get; set; }
        public string Password { get; set; }



        public string Username { get; set; }
        public string NickName { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
        public string Ip { get; set; }
        public string OpenTime { get; set; }
        public bool IsActive { get; set; }
        public string Locations { get; set; }
        public string Src { get; set; }
        public string AccountSid { get; set; }
    }
}
