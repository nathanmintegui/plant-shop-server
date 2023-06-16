namespace PlantShop.Domain.Models;

public class Pager
{
    public int Page { get; set; }
    public int PageSize { get; set; }

    public int Offset { get; set; }
    public int Next { get; set; }

    public Pager(int pageNumber, int pageSize = 10)
    {
        Page = pageNumber < 1 ? 1 : pageNumber;
        PageSize = pageSize < 1 ? 10 : pageSize;

        Next = pageSize;
        Offset = (Page - 1) * Next;
    }
}