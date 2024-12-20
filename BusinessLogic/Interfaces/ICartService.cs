﻿using CartServiceApp.DataAccess.Entities;
using KafkaDemo.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartServiceApp.BusinessLogic.Interfaces
{
    public interface ICartService
    {
        Cart GetCart(Guid id);
        List<CartItem> GetCartItems(Guid cartId);
        void AddCartItem(Guid cartId, CartItem cart);
        bool DeleteCartItem(Guid cartId, int cartItemId);
        void UpdateCartsItems(ProductChangedEvent productChangedEvent);
    }
}
