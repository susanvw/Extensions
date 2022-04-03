
namespace SvwDesign.Extensions.Models;

public abstract class BaseResponse
{
    public bool IsSuccess { get; set; } 

    public Result Result { get; set; } = null!;
}
