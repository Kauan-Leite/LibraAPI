namespace LibraAPI;



public class Book
{
   public enum GenderEnum
    {
        Ficcao,
        Romance,
        Misterio,
        Aventura,
        Acao
    }

    public int Id { get; set; } = 0;
    public string Title { get; set; } = string.Empty;
    public string Author { get; set; } = string.Empty;
    public GenderEnum Gender { get; set; } = GenderEnum.Ficcao;
    public double price { get; set; } = 0;
    public int qty { get; set; } = 0; 
}
