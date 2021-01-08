using System;

namespace Domain.Entities.Security
{
    [Serializable]
    public class LoginMemory
    {
        public User User { get; set; }
        public bool IsLoginSaved { get; set; }
    }
}
