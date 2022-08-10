namespace myDotNetTestApi
{
    public class CompanyResponse
    {
        public List<Company> Company { get; set; } = new List<Company>();
        public int Pages { get; set; }
        public int CurrentPage { get; set; }

    }
}
