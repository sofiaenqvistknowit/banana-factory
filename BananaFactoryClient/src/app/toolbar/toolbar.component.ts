import { Component, OnInit, Input} from '@angular/core';
import {Product} from '../../environments/models/Product.model'
import { ProductType } from 'src/environments/models/ProductType.model';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.css']
})
export class ToolbarComponent implements OnInit {
  @Input() public productTypes: ProductType[] = [];
  @Input() public getProductTypeCallback:Function;
  @Input() public privateOrCompanyCallback:Function;
  currentProductType: string = "Jo";
  numberOfProductsInChart = 0;
  
  public ngOnInit() {
  }

  constructor() {
  }




}
