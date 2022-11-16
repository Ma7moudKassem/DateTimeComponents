namespace DateTimeComponents.Client.Employees;

public partial class Employees
{
    List<Employee> employees = new();

    Employee Employee = new();

    private async void Post(Employee employee)
    {
        try
        {
            await _httpClinet.PostAsJsonAsync("api/employee", employee);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
