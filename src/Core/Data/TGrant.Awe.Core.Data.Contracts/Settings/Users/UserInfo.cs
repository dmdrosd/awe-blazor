using System.Collections.Generic;

namespace Awe.Application.Settings.Users
{
    public class UserInfo
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public UserGroupInfo UserGroup { get; set; }
        public int PersonId { get; set; }
        public string FirmaFilter { get; set; }
        public int FirmaId { get; set; }
        public Dictionary<string, object> UserStore { get; set; }
    }
}