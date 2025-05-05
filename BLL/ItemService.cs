using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;
using DAL.DTOs;
namespace BLL
{
    public class ItemService
    {
        private ItemRepository itemRepository;
        private readonly ItemRepository _itemRepository;

        public ItemService()
        {
            itemRepository = new ItemRepository();
        }

        public List<Item> GetAllItems()
        {
            return itemRepository.GetAllItems();
        }

        public void AddItem(Item item)
        {
            // You can add validation logic here if needed
            itemRepository.InsertItem(item);
        }

        public List<ItemReportDto> GetTopSellingItems()
        {
            return _itemRepository.GetTopSellingItems();
        }

        public List<ItemReportDto> GetItemsByAgent(int agentId)
        {
            return _itemRepository.GetItemsByAgent(agentId);
        }

        public List<PurchaseSummaryDto> GetAgentPurchaseSummary(int agentId)
        {
            return _itemRepository.GetAgentPurchaseSummary(agentId);
        }
    }
}

