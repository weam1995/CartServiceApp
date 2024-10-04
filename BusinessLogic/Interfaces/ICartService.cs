﻿using CartServiceApp.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartServiceApp.BusinessLogic.Interfaces
{
    public interface ICartService
    {
        List<CartItem> GetCartItems(int cartId);
        void AddCartItem(Cart cart, CartItem cartItem);
        bool DeleteCartItem(int cartId, CartItem cartItem);
    }
}