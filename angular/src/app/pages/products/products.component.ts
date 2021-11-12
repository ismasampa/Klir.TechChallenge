import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/app/api/services/product.service';
import { PromotionService } from 'src/app/api/services/promotion.service';
import { IPromotion, Product, PromotionType } from 'src/app/services/models/product';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

  products: Product[];
  prodpromo: string[] = new Array();
  promotions: IPromotion[];

  constructor(private productService: ProductService, private promotionService: PromotionService) { }

  ngOnInit() {
    this.productService.getApiProduct().subscribe(data => {
      this.products = data;
      this.products.forEach( x => this.prodpromo.push(x.currentPromotion?.description ?? ""));
      this.promotionService.getApiPromotion().subscribe(data => this.promotions = data);
    }
      );
  }

  getPromotionName(product : Product) {
    if (product == null || product?.currentPromotion == null ) {
      return "";
    }
    return product.currentPromotion.description;
  }

  promotionChange(product: Product, event){
    this.promotionService.getApiPromotion().subscribe(data => this.promotions = data);
    if( event == ""){
      this.productService.deleteApiProductIdRemovePromotion(product.id).subscribe(data => product = data);;
    }else{
      this.productService.postApiProductIdAddPromotion({
        id: product.id,
        promotionName: event
      }).subscribe(data => product = data);;
    }
  }

}
