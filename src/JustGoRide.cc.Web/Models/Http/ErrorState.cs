namespace JustGoRide.cc.Web.Models.Http
{
    public class ErrorState
    {
        public int HttpStatusCode { get; set; }
        public int InternalStatusCode { get; set; }
        public string  Message { get; set; }
        public string Description { get; set; }
    }
}
