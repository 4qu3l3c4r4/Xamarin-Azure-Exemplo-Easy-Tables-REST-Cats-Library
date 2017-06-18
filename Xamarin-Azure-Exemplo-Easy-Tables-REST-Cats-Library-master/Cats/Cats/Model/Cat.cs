using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.WindowsAzure.MobileServices;
namespace Cats.Model
{    [DataTable("Cats")]
    public class Cat
    {
        [Version]
        public string AzureVersion { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string WebSite { get; set; }
        public string Image { get; set; }
    }
}
