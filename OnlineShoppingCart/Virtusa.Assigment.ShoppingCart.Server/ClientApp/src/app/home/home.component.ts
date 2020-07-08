import { Component, NgModule } from '@angular/core';
import { FormControl } from '@angular/forms';
//import { MatToolbarModule } from '@angular/material/toolbar';
//import { MatIconModule } from '@angular/material/icon';
import { MatFormFieldModule } from '@angular/material/form-field';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css'],
})
@NgModule({
    imports: [
    FormControl,
    MatFormFieldModule,
   ],
  providers: [],
  bootstrap: [HomeComponent]
})

export class HomeComponent {
  selected = 'option2';
}
