public class SearchRequestDto
{
    public int ItemsRequested { get; set; }
    public int Page { get; set; }
    public string Category { get; set; }
    public string ProductTerm { get; set; }
    public string Tags { get; set; }
    public string Sort { get; set; }
    public string ImageTag { get; set; }
}
