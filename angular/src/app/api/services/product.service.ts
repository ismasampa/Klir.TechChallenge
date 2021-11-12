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
class ProductService extends __BaseService {
  static readonly getApiProductPath = '/api/Product';
  static readonly getApiProductIdPath = '/api/Product/{id}';
  static readonly getApiProductNamePath = '/api/Product/name}';
  static readonly postApiProductIdAddPromotionPath = '/api/Product/{id}/AddPromotion';
  static readonly deleteApiProductIdRemovePromotionPath = '/api/Product/{id}/RemovePromotion';

  constructor(
    config: __Configuration,
    http: HttpClient
  ) {
    super(config, http);
  }
  getApiProductResponse(): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;
    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Product`,
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
  }  getApiProduct(): __Observable<null> {
    return this.getApiProductResponse().pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param id undefined
   */
  getApiProductIdResponse(id: number): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Product/${encodeURIComponent(String(id))}`,
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
   * @param id undefined
   */
  getApiProductId(id: number): __Observable<null> {
    return this.getApiProductIdResponse(id).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param name undefined
   */
  getApiProductNameResponse(name: string): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'GET',
      this.rootUrl + `/api/Product/name}`,
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
   * @param name undefined
   */
  getApiProductName(name: string): __Observable<null> {
    return this.getApiProductNameResponse(name).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param params The `ProductService.PostApiProductIdAddPromotionParams` containing the following parameters:
   *
   * - `id`:
   *
   * - `promotionName`:
   */
  postApiProductIdAddPromotionResponse(params: ProductService.PostApiProductIdAddPromotionParams): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    if (params.promotionName != null) __params = __params.set('promotionName', params.promotionName.toString());
    let req = new HttpRequest<any>(
      'POST',
      this.rootUrl + `/api/Product/${encodeURIComponent(String(params.id))}/AddPromotion`,
      __body,
      {
        headers: __headers,
        params: __params,
        responseType: 'json'
      });
    try{
    return this.http.request<any>(req).pipe(
      __filter(_r => _r instanceof HttpResponse),
      __map((_r) => {
        return _r as __StrictHttpResponse<null>;
      })
    );}
    catch(error){
      console.log(error)
    };
  }
  /**
   * @param params The `ProductService.PostApiProductIdAddPromotionParams` containing the following parameters:
   *
   * - `id`:
   *
   * - `promotionName`:
   */
  postApiProductIdAddPromotion(params: ProductService.PostApiProductIdAddPromotionParams): __Observable<null> {
    return this.postApiProductIdAddPromotionResponse(params).pipe(
      __map(_r => _r.body as null)
    );
  }

  /**
   * @param id undefined
   */
  deleteApiProductIdRemovePromotionResponse(id: number): __Observable<__StrictHttpResponse<null>> {
    let __params = this.newParams();
    let __headers = new HttpHeaders();
    let __body: any = null;

    let req = new HttpRequest<any>(
      'DELETE',
      this.rootUrl + `/api/Product/${encodeURIComponent(String(id))}/RemovePromotion`,
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
   * @param id undefined
   */
  deleteApiProductIdRemovePromotion(id: number): __Observable<null> {
    return this.deleteApiProductIdRemovePromotionResponse(id).pipe(
      __map(_r => _r.body as null)
    );
  }
}

module ProductService {

  /**
   * Parameters for postApiProductIdAddPromotion
   */
  export interface PostApiProductIdAddPromotionParams {
    id: number;
    promotionName?: string;
  }
}

export { ProductService }
