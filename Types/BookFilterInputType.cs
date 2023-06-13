using HotChocolate.Data.Filters;

namespace hc_issue_abstract_base_class.Types;

public sealed class BookFilterInputType : FilterInputType<Book>
{
    protected override void Configure(IFilterInputTypeDescriptor<Book> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor
            .Field(a => a.Author.Id)
            .Name("authorId");
    }
}