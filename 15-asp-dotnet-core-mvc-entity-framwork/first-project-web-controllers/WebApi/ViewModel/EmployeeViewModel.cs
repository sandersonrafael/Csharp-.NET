using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.ViewModel;

public class EmployeeViewModel(string name, int age, string photo)
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public string Photo { get; set; } = photo;
}
