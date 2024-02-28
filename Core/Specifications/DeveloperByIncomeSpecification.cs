using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class DeveloperByIncomeSpecification : BaseSpecification<Developer>
    {
        public DeveloperByIncomeSpecification()
        {
            AddInclude(x => x.Address);
            AddOrderByDescending(x => x.EstimatedIncome);
        }
    }
}
