import { FoodModel } from './../models/vending.model';
import { VendingService } from './../services/vending.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vending',
  templateUrl: './vending.component.html',
  styleUrls: ['./vending.component.css']
})
export class VendingComponent implements OnInit {
  moneyValues: number[] = [2000, 5000, 10000, 20000, 50000];
  foods: FoodModel[] = [];
  selectedMoney: number;
  selectedFood: string;
  remainingMoney: number;
  currentMoney: number = 0;
  go: boolean = false;
  checked: boolean = false;
  constructor(private _vendingService: VendingService) { }

  ngOnInit() {
    this.getFoods();
  }

  getFoods() {
    this._vendingService.getFoods().subscribe(
      (res: any) => {
        this.foods = res;
      },
      error => {

      }
    )
  }
  checkout(id: number) {
    this._vendingService.checkout(id.toString()).subscribe(
      res => {
        this.onSuccess(id);
      },
      error => {

      }
    )
  }
  onSuccess(id){
    let food = this.foods.find(x => x.id == id);
    this.remainingMoney = this.currentMoney - food.foodPrice;
    this.selectedFood = food.foodName;
    this.checked = true;
    this.getFoods();
  }
  cancel(){
    this.remainingMoney = this.currentMoney;
    this.selectedFood = '-';
    this.checked = true;
  }
  updateMoney() {
    this.currentMoney = +this.currentMoney + +this.selectedMoney;
    this.go = true;
    this.selectedMoney = undefined;
  }
  done() {
    this.currentMoney = 0;
    this.go = false;
    this.checked = false;
    this.selectedMoney = undefined;
  }
}
