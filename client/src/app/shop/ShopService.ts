import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Injectable({
  providedIn: 'root'
})
export class ShopService {

  baseUrl = 'https://localhost:5001/api';

  constructor(private http: HttpClient) { }

  getProducts() {

    return this.http.get(this.baseUrl + 'products');
  }
}
