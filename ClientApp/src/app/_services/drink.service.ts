import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class DrinkService {
  baseUrl = 'http://localhost:5247/api/';

  constructor(private http: HttpClient) {}

  getAllDrinks() {
    return this.http.get(this.baseUrl + 'Drinks');
  }
}
