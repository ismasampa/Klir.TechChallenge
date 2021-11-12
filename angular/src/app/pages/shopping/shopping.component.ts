import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/api/services/product.service';
import { Product } from 'src/app/services/models/product';

@Component({
  selector: 'app-shopping',
  templateUrl: './shopping.component.html',
})
export class ShoppingComponent implements OnInit {
  products: Product[];
  hasCart: boolean;

  constructor(private productService: ProductService) { }

  ngOnInit() {
    this.productService.getApiProduct().subscribe(data => this.products = data);    
  }
}
