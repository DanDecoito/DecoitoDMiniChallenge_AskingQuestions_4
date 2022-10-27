// Daniel Decoito
// 10-25-22
// Mini Challenge 4 
// use api to return two response in a text
// reviewd by: Andrea Burr i like the code well it works no matter the input ot will return the response.



 
using Microsoft.AspNetCore.Mvc;

namespace DecoitoDMiniChallenge_AskingQuestions_4.Controllers;

[ApiController]
[Route("[controller]")]
public class AskingQuestionsController : ControllerBase
{
    
[HttpGet]
[Route("Question/{name}/{time}")]

public string Question(string name, string time)
{
    return $"Hello {name} you woke up at {time} today";
}



}
