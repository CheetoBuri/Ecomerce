using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace BLL
{
    public class ItemService
    {
        private ItemRepository itemRepository;

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
    }
}

