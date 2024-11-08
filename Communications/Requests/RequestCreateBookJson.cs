namespace LibraAPI.Communications.Requests;

public class RequestCreateBookJson
{
    public Book.GenderEnum Gender { get; set; }
    public string Author { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int qty { get; set; } = 0;
    public double price { get; set; } = 0;

}
