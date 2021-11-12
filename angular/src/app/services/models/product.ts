/* tslint:disable */
export interface Product {
  currentPromotion?: IPromotion;
  id?: number;
  name?: string;
  price?: number;
}

export interface IPromotion {
    description: string;
    type: PromotionType;
    finalValue: number;
    quantity : number;
  }

export enum PromotionType {
    'Quantity X Price'
}