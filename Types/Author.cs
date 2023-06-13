namespace hc_issue_abstract_base_class.Types;

public class Author : Entity
{
    // Uncomment this to fix the filtering.
    //public new long Id { get; set; }

    public string Name { get; set; } = null!;
}
