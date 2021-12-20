using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceService.Application.Contracts
{
    public static class WorkspaceHelpers
    {
        public static class Roles
        {
            public const string Administrator = "Administrator";
            public const string Basic = "Basic";

            public static List<String> GetRoles()
            {
                return new List<string> { Administrator, Basic };
            }
        }
    }
}
