import { Component, Inject, NgModule } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Data } from '@angular/router';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})

@NgModule({
  declarations: [
  ],
  imports: [
    HttpClient,
    
  ],
  providers: [],
  bootstrap: [FetchDataComponent]
})
export class FetchDataComponent {

  public forecasts: WeatherForecast[];

  public category: Category[];
  public products: Product[];
  selectedLevel;
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Category[]>(baseUrl + 'api/Category').subscribe(result => {
      this.category = result;
    }, error => console.error(error));
   
    http.get<Product[]>(baseUrl + 'api/product/products/2').subscribe(results => {
      this.products = results;
      console.log(results);
    }, error => console.error(error));
  }


  selected(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    console.log(this.selectedLevel);
    
   
  }
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
interface Category {
  id: string;
  Name: string;
  isActive: boolean;
  CreateUser: string;
  ModifiedDate: Date;
  ModifiedUser: string;
}
interface Product {
  Id: string;
  Name: string;
  Discription: string;
  StockAvailability: boolean;
  Qty: number;
  UnitPrice: number;
  SellingPrice: number;
  Discount: number;
  CreateDate: Date;
  IsActive: boolean
  CreateUser: string;
  ModifiedDate: Date;
  ModifiedUser: string;
  CategryId: number;
  CategoryEntityId: number;
}




