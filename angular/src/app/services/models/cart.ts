import { Product } from "./product";

export interface Cart {
  cartItems?: Array<CartItem>;
  total?: number;
}

export interface CartItem {
    price?: number;
    product?: Product;
    quantity?: number;
    total?: number;
  }