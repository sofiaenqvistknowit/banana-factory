import { Component, OnInit, Input} from '@angular/core';

@Component({
  selector: 'app-toolbar',
  templateUrl: './toolbar.component.html',
  styleUrls: ['./toolbar.component.css']
})
export class ToolbarComponent implements OnInit {
  @Input()
  public productTypes: string[] = [];
  @Input()
  public getProductTypeCallback:Function;
  currentProductType: string = null;
  numberOfProductsInChart = 0;
  
  public ngOnInit() {
  }

  constructor() {
  }

  typeCallback = (e) => {
    console.log(e.target.value);
  }

  goToPrivate(e) {
    alert(e.target.value);
  }

}
