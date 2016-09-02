using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using SyncTest;

namespace Sync.Host
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var host = new ServiceHost(typeof(TestScopeSyncService)))
            {
                host.Open();
                Console.WriteLine("ServiceHost started");
                Console.ReadLine();
                host.Close();
            }

        }
    }
}
