using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementDemo.DTO
{
    public class UserDt
    {
        public string Id { get; set; }
        public string Email { get; set; }

        public List<ProjectUserDt> ProjectUsers { get; set; }
    }
}
