using ProjectManagementDemo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementDemo.BL.Interaces
{
    public interface IProjectRepository
    {
        ProjectDt Get(int id);
        List<ProjectDt> Get(string userId);
    }
}
