using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementDemo.DTO
{
    public class ProjectUserDt
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int ProjectId { get; set; }

        public UserDt User { get; set; }
        public ProjectDt Project { get; set; }
    }
}
