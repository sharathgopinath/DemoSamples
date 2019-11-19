using ProjectManagementDemo.BL.Interaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementDemo.DTO;

namespace ProjectManagementDemo.DAL
{
    public class ProjectRepository : IProjectRepository
    {
        public List<ProjectDt> Get(string userId)
        {
            throw new NotImplementedException();
        }

        public ProjectDt Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
