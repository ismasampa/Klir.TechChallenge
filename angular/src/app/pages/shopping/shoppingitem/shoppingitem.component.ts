import { Component, Input, OnInit, Output } from '@angular/core';
import { CartService } from 'src/app/api/services/cart.service';
import { Cart } from 'src/app/services/models/cart';
import { Product } from 'src/app/services/models/product';

@Component({
  selector: '[app-shoppingitem]',
  templateUrl: './shoppingitem.component.html',
  styleUrls: ['./shoppingitem.component.css']
})
export class ShoppingitemComponent implements OnInit {

  currentItems: number;
  currentTotal: number;

  constructor(private cartService: CartService) { }

  ngOnInit() {
    this.currentTotal = 0;
    this.currentItems = 0;

    this.cartService.getApiCart().subscribe(data => this.updateState(data));
  }

  getPromotionDescription(): string {
    if (this.product.currentPromotion == null) {
      return "";
    }
    return this.product.currentPromotion.description;
  }

  public increment() {
    this.currentItems++

    this.cartService.postApiCartProductIdSetquantityQuantity({
      quantity: this.currentItems,
      productId: this.product.id
    }).subscribe(data => this.updateState(data));
  }

  public decrement() {
    this.currentItems--;

    if (this.currentItems < 0) this.currentItems = 0;

    if (this.currentItems == 0) {
      this.cartService.deleteApiCartProductId(this.product.id).subscribe(data => this.updateState(data));
      return;
    }

    this.cartService.postApiCartProductIdSetquantityQuantity({
      quantity: this.currentItems,
      productId: this.product.id
    }).subscribe(data => this.updateState(data));
  }

  updateState(cart: Cart) {
    console.log(this.hascart);
    if (cart.cartItems?.length == 0) {
      this.currentTotal = 0;
      this.currentItems = 0;
      this.hascart = false;
      return;
    }

    const item = cart.cartItems?.find(i => { return i.product.id === this.product.id });

    if (item) {
      this.currentTotal = item.total;
      this.currentItems = item.quantity;
    } else {
      this.currentTotal = 0;
      this.currentItems = 0;
      this.hascart = false;
    }
    
    this.hascart = cart.cartItems?.find(i => { return i.quantity > 0 }) != undefined;
  }

  @Input() product: Product;
  @Output() hascart: boolean;

}
