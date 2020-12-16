import { FoodModel } from './../models/vending.model';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class VendingService {
  root: string = 'food/';
  constructor(private _http: HttpClient) { }
  getFoods() {
    return this._http.get(this.root);
  }
  checkout(id: string, payload = {}) {
    return this._http.put(this.root + id, payload);
  }
}
