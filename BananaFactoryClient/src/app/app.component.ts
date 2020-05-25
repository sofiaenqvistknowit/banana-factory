import { Component } from '@angular/core';
import { ContextComponent } from './context/context.component';
import { ProductService } from './product.service';
import{Product} from '../environments/models/Product.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'BananaFactoryClient';
  loggedIn = false;
  productTypes: string[] = [];
  getProductTypeCallback:Function;
  public theTypeBoundCallback: Function;
  currentProductType:string = null;
  show:boolean = false;
   constructor(private productService: ProductService){}
  public ngOnInit(){
    this.getProductTypeCallback = this.typeCallback.bind;
    this.getProductTypeCallback= 
              obj => this.typeCallback(obj);
    this.productTypes = this.productService.GetProductTypes();

  }

  public changeIconSrc(){
    if(this.loggedIn === false){

    }
  }

  public typeCallback(e){
    this.currentProductType = e.target.value;
    console.log(e.target.value);
    ContextComponent.yourString.next(this.currentProductType);
  }
  privateOrCompany(e) {
    let value = e.target.value;
  };

}
