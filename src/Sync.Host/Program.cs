using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Synchronization.Services;
using SyncTest;

namespace Sync.Host
{

    public class SyncHostFactory<TSyncService> : SyncServiceHostFactory
    {

        public override ServiceHostBase CreateServiceHost(string constructorString, Uri[] baseAddresses)
        {
            return this.CreateServiceHost(typeof(TSyncService), baseAddresses);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var factory = new SyncHostFactory<TestScopeSyncService>();
            using (
                var host = factory.CreateServiceHost("", new Uri[] { new Uri("http://localhost:9554") }))
            {

                host.Open();
                Console.WriteLine("ServiceHost started");
                Console.ReadLine();
                host.Close();
            }

          
            //using (var host = new ServiceHost(typeof(TestScopeSyncService), ))
            //{
            //    host.Open();
            //    Console.WriteLine("ServiceHost started");
            //    Console.ReadLine();
            //    host.Close();
            //}

        }
    }
}
