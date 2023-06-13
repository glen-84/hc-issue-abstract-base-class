namespace hc_issue_abstract_base_class.Types;

public class Book : Entity
{
    public string Title { get; set; } = null!;

    public Author Author { get; set; } = null!;
}
