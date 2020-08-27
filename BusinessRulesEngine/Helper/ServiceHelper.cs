using BusinessRulesEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Helper
{
    public static class ServiceHelper
    {
        public static void GenerateSlip(Services service)
        {
            Console.WriteLine("Packing slip generated for " + service);
            
        }
        public static void CreateDuplicateSlip(Services service)
        {
            Console.WriteLine("Duplicate packing slip created for " + service);
        }
        public static void ActivateMembership(Services service)
        {
            Console.WriteLine("Membership activated for " + service);
        }
        public static void UpgradeMembership(Services service)
        {
            Console.WriteLine("Membership upgraded for " + service);
        }
        public static void SendEmailToOwner(Services service)
        {
            Console.WriteLine("Email Sent to the " + service);
        }
        public static void AddFreeVideo(VideoCategories category)
        {
            Console.WriteLine("The free video added: " + category);
        }
        public static void GenerateCommision(Services service)
        {
            Console.WriteLine("Commission generated for " + service);
        }
    }
}
