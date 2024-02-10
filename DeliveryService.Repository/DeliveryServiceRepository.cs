using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryService.Data;

namespace DeliveryService.Repository
{
    public class DeliveryServiceRepository
    {
        private List<Delivery> _deliveryDirectory = new List<Delivery>();

//NOTE - Add deliveries (CREATE)    
        public bool AddDeliverytoList(Delivery delivery)
        {
            int startingCount = _deliveryDirectory.Count;
            _deliveryDirectory.Add(delivery);
            bool wasAdded = (_deliveryDirectory.Count >startingCount) ? true: false;
            return wasAdded;
        }

//NOTE - List of Deliveries (READ)
        public List<Delivery> GetDeliveryList()
        {
            return _deliveryDirectory;
        }

//NOTE - Delete Deliveries (Delete)
        public bool RemoveDeliveryFromList(int id)
        {
            
            int initialCount = _deliveryDirectory.Count;
            _deliveryDirectory.RemoveAt(id);

            if (initialCount > _deliveryDirectory.Count)
            {
            return true;
            }
            else
            {
            return false;
            }
         }

    }
}