using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryClient.Models
{
    public class Data
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string VersionName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CurrentRelease { get; set; }
    }
}
