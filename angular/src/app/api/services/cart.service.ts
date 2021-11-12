/* tslint:disable */
import { Injectable } from '@angular/core';
import { HttpClient, HttpRequest, HttpResponse, HttpHeaders } from '@angular/common/http';
import { BaseService as __BaseService } from '../base-service';
import { ApiConfiguration as __Configuration } from '../api-configuration';
import { StrictHttpResponse as __StrictHttpResponse } from '../strict-http-response';
import { Observable as __Observable } from 'rxjs';
import { map as __map, filter as __filter } from 'rxjs/operators';

@Injectable({
  providedIn: 'root',
})
class CartService extends __BaseService {
  static readonly getApiCartPath = '/api/Cart';
  static readonly postApiCartProductIdSetquantityQuantityPath = '/api/Cart/{productId}/setquantity/{quantity}';
  static readonly deleteApiCartProductIdPath = '/api/Cart/{productId}';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }
  getApiCartResponse(): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Cart`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }  getApiCart(): __Observable<null> {
    return this.getApiCartResponse().pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `CartService.PostApiCartProductIdSetquantityQuantityParams` containing the following parameters:
   *
   * - `quantity`:
   *
   * - `productId`:
   */
  postApiCartProductIdSetquantityQuantityResponse(params: CartService.PostApiCartProductIdSetquantityQuantityParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;


    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/Cart/${encodeURIComponent(String(params.productId))}/setquantity/${encodeURIComponent(String(params.quantity))}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param params The `CartService.PostApiCartProductIdSetquantityQuantityParams` containing the following parameters:
   *
   * - `quantity`:
   *
   * - `productId`:
   */
  postApiCartProductIdSetquantityQuantity(params: CartService.PostApiCartProductIdSetquantityQuantityParams): __Observable<null> {
    return this.postApiCartProductIdSetquantityQuantityResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param productId undefined
   */
  deleteApiCartProductIdResponse(productId: number): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/Cart/${encodeURIComponent(String(productId))}`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });

    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );
  }
  /**
   * @param productId undefined
   */
  deleteApiCartProductId(productId: number): __Observable<null> {
    return this.deleteApiCartProductIdResponse(productId).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module CartService {

  /**
   * Parameters for postApiCartProductIdSetquantityQuantity
   */
  export interface PostApiCartProductIdSetquantityQuantityParams {
    quantity: number;
    productId: number;
  }
}

export { CartService }
