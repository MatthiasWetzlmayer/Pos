namespace JwtDemo.Controllers
{
  public class AuthenticationDto
  {
    public int Id { get; internal set; }
    public string Username { get; internal set; }
    public string FirstName { get; internal set; }
    public string LastName { get; internal set; }
    public string Token { get; internal set; }
  }
}
