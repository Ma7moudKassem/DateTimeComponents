namespace DateTimeComponents.Server;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public EmployeeController(ApplicationDbContext context) => _context = context;

    [HttpPost]
    public async Task Post(Employee employee)
    {
        try
        {
            await _context.Employees.AddAsync(employee);

            await _context.SaveChangesAsync();
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }

    [HttpGet]
    public async Task<List<Employee>> Get() => await _context.Employees.ToListAsync();
}
