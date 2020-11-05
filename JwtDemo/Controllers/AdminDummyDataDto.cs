namespace JwtDemo.Controllers
{
  public class AdminDummyDataDto
  {
    public bool IsOk { get; set; } = true;

    private string errorMessage;
    public string ErrorMessage
    {
      get => errorMessage;
      set
      {
        errorMessage = value;
        IsOk = false;
      }
    }

  }
}
