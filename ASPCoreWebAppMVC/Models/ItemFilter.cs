using System.Collections.Generic;

namespace ASPCoreWebAppMVC.Models
{
    public class ItemFilter
    {
        public List<Item> Items { get; set; }
        public int? AgentID { get; set; }
        public bool ShowBestItems { get; set; }
        public List<Agent> Agents { get; set; }
    }
}
