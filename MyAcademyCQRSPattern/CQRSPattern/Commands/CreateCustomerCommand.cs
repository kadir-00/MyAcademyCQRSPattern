namespace MyAcademyCQRSPattern.CQRSPattern.Commands
{
    public class CreateCustomerCommand
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
    }
}
