using HotChocolate.Data;

namespace hc_issue_abstract_base_class.Types;

[QueryType]
public static class Query
{
    [UseFiltering<BookFilterInputType>]
    public static IQueryable<Book> GetBook()
    {
        return new List<Book>() {
            new Book()
            {
                Id = 1,
                Title = "title 1",
                Author = new() { Id = 10, Name = "Author 1" }
            },
            new Book()
            {
                Id = 2,
                Title = "title 2",
                Author = new() { Id = 20, Name = "Author 2" }
            }
        }.AsQueryable();
    }
}
