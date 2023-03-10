using System;

namespace ECOTRAVEL_ASP.Handlers
{
    public class CurrentUser
    {
        public int IdUser { get; set; }
        public string Email { get; set; }
        public DateTime LastConnection { get; set; }
    }
}
