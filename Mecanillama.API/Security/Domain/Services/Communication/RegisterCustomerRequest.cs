namespace Mecanillama.API.Security.Domain.Services.Communication;
    public class RegisterCustomerRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string CarMake { get; set; }
    }
