using Microsoft.AspNetCore.Mvc;
using WebApi.Model;
using WebApi.ViewModel;

namespace WebApi.Controllers;

[ApiController]
[Route("api/v1/employee")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeRepository _repository;

    public EmployeeController(IEmployeeRepository repository)
    {
        _repository = repository;
    }

    [HttpPost] // FromForm makes a multipart instead of json
    public IActionResult Add([FromForm] EmployeeViewModel viewModel)
    {
        var employee = new Employee(viewModel.Name, viewModel.Age, null);
        _repository.Add(employee);
        return Created();
    }

    [HttpGet]
    public IActionResult Get()
    {
        var employee = _repository.Get();
        return Ok(employee);
    }
}
