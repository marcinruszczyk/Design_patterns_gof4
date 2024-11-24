using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_pattern
{
    public class Singleton
    {
        static Singleton instance;

        public Singleton()
        {
            
        }

        public static Singleton Instance()
        {
            if (instance == null) 
            {
                instance = new Singleton(); 
            }
            return instance;
        }
    }
}
