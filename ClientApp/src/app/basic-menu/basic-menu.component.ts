import { CloseScrollStrategy } from '@angular/cdk/overlay';
import { elementEventFullName } from '@angular/compiler/src/view_compiler/view_compiler';
import { Component, OnInit } from '@angular/core';
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
  sodas: any= [];

  constructor(private drinkService: DrinkService) {
  
  }
  
  ngOnInit(): void {
    this.getAllDrinks();
    
  }
  getAllDrinks() {
    this.drinkService.getAllDrinks().subscribe(drinks =>{
      this.drinks = drinks;
      console.log(drinks);
      this.getSodaBaseFromDrinks();
    })
}
  getSodaBaseFromDrinks(){
    
    var sodaArray: any = [];
    for (let index = 0; index < this.drinks.length; index++) {
      const element : string = this.drinks[index].sodaBase;
      console.log("Element: " + element);
      if(!sodaArray.includes(element)){
        console.log(sodaArray.includes(element))
        sodaArray.push(element)
        console.log("Sodas: " + sodaArray)
      }else {
      }
    }
    this.sodas = sodaArray;
    console.log(sodaArray);
  }
 }

