
using CustomExceptionV;

User user = new User();

try
{

    user.SetAge(19);

}
catch(InvalidAgeException ex)
{
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}