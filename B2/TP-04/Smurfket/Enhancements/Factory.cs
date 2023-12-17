namespace Smurfket.Enhancements;

public class Factory
{
    private List<Employee> _employees;

    public Factory()
    {
        Employees = new List<Employee> { };
    }
    
    public List<Employee> Employees
    {
        get => _employees;
        set => _employees = value;
    }

    public void HireEmployee(Employee employee)
    {
        Employees.Add(employee);
    }

    public List<string> Product()
    {
        List<string> str = new List<string>();

        foreach (Employee employeee in Employees)
        {
            if (employeee is HatWorker em1)
                str.Add(em1.MakeHat());
            else if (employeee is ShortWorker em2)
                str.Add(em2.MakeShort());
            else if (employeee is Supervisor em3)
                str.Add(em3.SuperviseWork());
            else str.Add(employeee.Work());
        }

        return str;
    }

    public List<string> IntroduceEmployees()
    {
        List<string> str = new List<string>();

        foreach (Employee employeee in Employees)
        {
            str.Add(employeee.IntroducePerson());
        }

        return str;
    }

    public List<string> RealIntroduceEmployees()
    {
        List<string> str = new List<string>();

        foreach (Employee employeee in Employees)
        {
            if (employeee is HatWorker em1)
                str.Add(em1.Introduce());
            else if (employeee is ShortWorker em2)
                str.Add(em2.Introduce());
            else if (employeee is Supervisor em3)
                str.Add(em3.Introduce());
            else str.Add(employeee.IntroducePerson());
        }

        return str;
    }
}