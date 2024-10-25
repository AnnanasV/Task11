namespace Attributes
{
    public class DocumentationAttribute : Attribute
    {
        public string Author { get; set; }
        public int Version { get; set; }

        public DocumentationAttribute (string author)
        {
            Author = author;
        }
    }
}