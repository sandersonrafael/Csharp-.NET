using Composition.Entities.Enums;

namespace Composition.Entities
{
    public class Worker
    {
        public string? Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }

        public Department? Department { get; set; }
        public List<HourContract> HourContracts { get; private set; } = [];

        public Worker(string? name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            HourContracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            HourContracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double total = BaseSalary;

            HourContracts.ForEach(contract =>
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    total += contract.TotalValue();
                }
            });

            return total;
        }
    }
}
