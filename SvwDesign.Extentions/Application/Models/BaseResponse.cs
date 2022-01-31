
namespace SvwDesign.Extensions.Models
{
    public abstract class BaseResponse
    {
        public int StatusCode { get; set; }

        public string Message { get; set; } = string.Empty;

        public Result Result { get; set; } = null!;
    }
}
