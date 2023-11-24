using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

[ApiController]
[Route("/api/[controller]")]
public class TaskController : ControllerBase {
  public TaskController(){
    // dependency inject here
  }
  // add methods here
}