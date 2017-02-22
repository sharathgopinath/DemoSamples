using ProjectManagementDemo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementDemo.BL.Interaces
{
    public interface IProjectManager
    {
        List<ProjectDt> Get(string userId);
    }
}
