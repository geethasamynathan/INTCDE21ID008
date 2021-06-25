import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'AugularApp1';
  Name="Geetha";
 message ="Learning about Binding";
username:string="Cohort";
  imagepath:string="./assets/image1.jpg";
  imagepath1:string="./assets/image2.jpg";
  showme()
  {
   this.message=" Learning  Event Binding";
  }

}
