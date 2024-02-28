using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class DeveloperWithAddressSpecification : BaseSpecification<Developer>
    {
        public DeveloperWithAddressSpecification(int years) : base(x => x.YearsOfExperience > years)
        {
            AddInclude(x => x.Address);
        }
    }
}
