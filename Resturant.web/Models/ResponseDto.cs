namespace Resturant.web.Models
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public object Result { get; set; } //msh aref no3 result
        public string DisplayMsg { get; set; }
        public List<string> ErrorMsg{ get; set; }
    }
}
