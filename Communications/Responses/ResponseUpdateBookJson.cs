namespace LibraAPI.Communications.Responses;

public class ResponseUpdateBookJson
{
    public int Id { get; set; } = 0;
    public Book.GenderEnum Gender { get; set; }
    public string Author { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public int Qty { get; set; } = 0;
    public double Price { get; set; } = 0;
}
