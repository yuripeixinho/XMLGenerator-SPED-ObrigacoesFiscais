//using Microsoft.AspNetCore.Mvc;
//using OF.Manager.Interfaces.Manager;

//namespace OF.WebApi.Controllers;

//public class DeclaranteController : ApiControllerBase
//{
//    private readonly IDeclaranteManager _declaranteManager;

//    public DeclaranteController(IDeclaranteManager DeclaranteManager)
//    {
//        _DeclaranteManager = DeclaranteManager;
//    }

//    [HttpGet]
//    [Route("/declarantes")]
//    public async Task<IActionResult> GetAllDeclarantes()
//    {
//        return Ok(await _declaranteManager.GetUsersAsync());
//    }
//}
