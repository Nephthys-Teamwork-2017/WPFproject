using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace Client
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var context = new InsuranceBrokerManagementSystem();
            context.Database.Initialize(true);
        }
    }
}
