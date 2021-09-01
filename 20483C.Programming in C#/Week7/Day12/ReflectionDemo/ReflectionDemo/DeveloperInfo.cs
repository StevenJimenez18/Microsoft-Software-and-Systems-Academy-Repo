using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{

    [Serializable]
    [Obsolete]
    [DeveloperInfo("someguy", 8)]
    public class book
    {
        [DeveloperInfo("otherguy", 6)]
        public void Display()
        {

        }
    }

    [AttributeUsage(AttributeTargets.All)]
    class DeveloperInfo : Attribute
    {
        private string email;
        private int build;

        
        public DeveloperInfo(string email, int build)
        {
            this.email = email;
            this.build = build;
        }
    }
}
