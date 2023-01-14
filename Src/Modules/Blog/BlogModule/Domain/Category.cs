using Common.Domain;

namespace BlogModule.Domain;

class Category : BaseAggregateRoot
{
    public string Title { get; set; }
    public string Slug { get; set; }
}