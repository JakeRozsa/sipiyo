import { CloseScrollStrategy } from '@angular/cdk/overlay';
import { elementEventFullName } from '@angular/compiler/src/view_compiler/view_compiler';
import { Component, Input, OnInit } from '@angular/core';
import { isObservable } from 'rxjs';
import { Drink } from '../models/drink';
import { DrinkService } from '../_services/drink.service';

@Component({
  selector: 'app-basic-menu',
  templateUrl: './basic-menu.component.html',
  styleUrls: ['./basic-menu.component.css']
})
export class BasicMenuComponent implements OnInit {
  drinks: any = [];
  sodas: any = [];
  filteredDrinks: any = [];
 @Input() soda: string = "Dr. Pepper";

  constructor(private drinkService: DrinkService) {
    this.getDrinksBySoda();
  }

  ngOnInit(): void {
    this.getAllDrinks();
    this.getDrinksBySoda();
  }
  getAllDrinks() {
    this.drinkService.getAllDrinks().subscribe(drinks => {
      this.drinks = drinks;
      this.getSodaBaseFromDrinks();
    })
  }
  getSodaBaseFromDrinks() {

    var sodaArray: any = [];
    for (let index = 0; index < this.drinks.length; index++) {
      const element: string = this.drinks[index].sodaBase;
      if (!sodaArray.includes(element)) {
        sodaArray.push(element)
      } else {
      }
    }
    this.sodas = sodaArray;
    console.log("this.sodas: " +this.sodas)
  }

  getDrinksBySoda() {
    this.drinkService.getAllDrinks().subscribe(drinks => {
      this.drinks = drinks;
      var drinkArray: any = [];
      for (let index = 0; index < this.drinks.length; index++) {
        const element = this.drinks[index].sodaBase;
        if (element == this.soda){
          drinkArray.push(this.drinks[index])
        }
      }
      this.filteredDrinks = drinkArray;
    })
  }

  getAddins(sodaName) {
    
  }
}

