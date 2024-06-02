using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SerialiseAnObject
{
    public class Account
    {
        public string? Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Account account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
                {
                    "User",
                    "Developer",
                    "Admin"
                }
            };

            // Serialize an object
            string json = JsonConvert.SerializeObject(account, Newtonsoft.Json.Formatting.Indented);
            Console.WriteLine(json);
            Console.WriteLine("-----------------------");

            // Deserialize an object
            account = JsonConvert.DeserializeObject<Account>(json);
            Console.WriteLine(account.Email);
            Console.WriteLine("-----------------------");

            // Print out roles for account
            foreach (string role in account.Roles)
            {
                Console.WriteLine(role);
            }

            Console.ReadLine();
        }
    }
}
