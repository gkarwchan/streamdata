
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class TestmeController: ControllerBase
{
    [HttpGet(Name = "getall")]
    public async IAsyncEnumerable<string> Get()
    {
        HttpContext.Features.Get<IHttpResponseBodyFeature>()?.DisableBuffering();
        foreach (var data in Enumerable.Range(1, 10))
        {
            await Task.Delay(TimeSpan.FromSeconds(1));
            yield return data.ToString();
        }
        
    }
}