import { Component } from '@angular/core';
import { DrinkService } from '../_services/drink.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  drinks: any = [];

  constructor(private drinkService: DrinkService) {
    this.drinkService.getAllDrinks().subscribe((drinks) => {
      this.drinks = drinks;
      console.log(drinks);
    });
  }
}
