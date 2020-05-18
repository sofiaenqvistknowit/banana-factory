import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'BananaFactoryClient';
  productTypes: string[] = [];
  getProductTypeCallback:Function;
  public theTypeBoundCallback: Function;
  currentProductType:string = "";


  public ngOnInit(){
    this.getProductTypeCallback = this.typeCallback.bind;
    this.getProductTypeCallback= 
              obj => this.typeCallback(obj);
    this.productTypes = ["APA","ÄTER","HALLONEN","BANANERNA","ÄR", "DET","INGEN", "SOM","ÄTER"];

  }


  public typeCallback(e){
    this.currentProductType = e.target.value;
  }

}
