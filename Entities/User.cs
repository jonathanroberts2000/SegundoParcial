using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Enabled { get; set; }
        public EProfile ProfileType { get; set; }
    }

    public enum EProfile
    {
        Administrator = 0,
        Operator = 1,
        Reader = 2
    }
}
