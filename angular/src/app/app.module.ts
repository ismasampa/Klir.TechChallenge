import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './pages/nav-menu/nav-menu.component';
import { ShoppingComponent } from './pages/shopping/shopping.component';
import { ProductsComponent } from './pages/products/products.component';
import { ShoppingitemComponent } from './pages/shopping/shoppingitem/shoppingitem.component';


@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    ShoppingComponent,
    ProductsComponent,
    ShoppingitemComponent,
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: ShoppingComponent, pathMatch: 'full' },
      { path: 'products', component: ProductsComponent },
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
