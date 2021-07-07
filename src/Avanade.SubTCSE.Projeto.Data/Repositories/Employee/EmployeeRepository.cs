using Avanade.SubTCSE.Projeto.Data.Repositories.Base;
using Avanade.SubTCSE.Projeto.Domain.Aggregates.EmployeeRole.Interfaces.Repository;
using Avanade.SubTCSE.Projeto.Domain.Base.Repository;
using System.Threading.Tasks;

namespace Avanade.SubTCSE.Projeto.Data.Repositories.Employee
{
    public class EmployeeRepository : BaseRepository<Domain.Aggregates.Employee.Entities.Employee, string>
    , IBaseRepository
    { 
    }
}
