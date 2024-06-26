
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class TestmeController: ControllerBase
{
    [HttpGet(Name = "getall")]
    public async IAsyncEnumerable<string> Get()
    {
        foreach (var data in Enumerable.Range(1, 10))
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            yield return data.ToString();
        }
        
    }
}