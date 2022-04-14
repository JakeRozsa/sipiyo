import { Component, OnInit } from '@angular/core';
import { DrinkService } from '../_services/drink.service';

@Component({
  selector: 'app-basic-menu',
  templateUrl: './basic-menu.component.html',
  styleUrls: ['./basic-menu.component.css']
})
export class BasicMenuComponent implements OnInit {
  drinks: any = [];
  sodaBases: any = [];

  constructor(private drinkService: DrinkService) {
    this.drinkService.getAllDrinks().subscribe((drinks) =>{
      this.drinks = drinks;
      console.log(drinks);
    })
   }

  ngOnInit(): void {
  }

}
