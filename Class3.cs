// Controllers/BomController.cs
using System.Collections.Generic;

[ApiController]
[Route("api/[controller]")]
public class BomController : ControllerBase
{
    private readonly BomService _bomService;

    public BomController(BomService bomService)
    {
        _bomService = bomService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<BomModel>> GetBomData()
    {
        var bomData = _bomService.GetBomData();
        return Ok(bomData);
    }
}

// Controllers/PartController.cs
[ApiController]
[Route("api/[controller]")]
public class PartController : ControllerBase
{
    private readonly PartService _partService;

    public PartController(PartService partService)
    {
        _partService = partService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<PartModel>> GetPartData()
    {
        var partData = _partService.GetPartData();
        return Ok(partData);
    }
}
