using System.Collections.Generic;
using System.Linq;

namespace BanHangOnline.Models
{
    public class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; set; }
        public ShoppingCart()
        {
            this.Items = new List<ShoppingCartItem>();
        }

        public void AddToCart(ShoppingCartItem item, int Quantity)
        {
            var checkExists = Items.FirstOrDefault(x => x.ProductId == item.ProductId);
            if (checkExists != null)
            {
                checkExists.Quantity += Quantity;
                checkExists.TotalPrice += checkExists.Quantity * checkExists.Price;
            }
            else
            {
                Items.Add(item);
            }
        }

        public void Remove(int id)
        {
            var checkExists = Items.SingleOrDefault(x => x.ProductId == id);
            if (checkExists != null)
            {
                Items.Remove(checkExists);
            }
        }

        public void UpdateQuantity(int id, int quantity)
        {
            var checkExists = Items.SingleOrDefault(x => x.ProductId == id);
            if (checkExists != null)
            {
                checkExists.Quantity = quantity;
                checkExists.TotalPrice = checkExists.Quantity * checkExists.Price;
            }
        }

        public decimal GetTotal()
        {
            return Items.Sum(x => x.TotalPrice);
        }

        public decimal GetTotalQuantity()
        {
            return Items.Sum(x => x.Quantity);
        }

        public void ClearCart()
        {
            Items.Clear();
        }
    }

    public class ShoppingCartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string ProductImage { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
    }
}