namespace Identitiy.Dtos
{
    public record LoginDto(string UserName, string Password);
    public record TokenDto(string token);
    public record RegistDto(string UserName, string Password, string Email, string Department);

    
}
