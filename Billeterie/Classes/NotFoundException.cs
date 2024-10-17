namespace Billeterie.Classes;

public class NotFoundException : Exception
{
    public override string Message { get; }
    
    public NotFoundException(string message)
    {
        Message = message;
    }
    
    public NotFoundException()
    {
        Message = "Le billet n'a pas été trouvé";
    }
}