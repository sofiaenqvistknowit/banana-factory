import { Component, OnInit, Input} from '@angular/core';
import { Subject } from 'rxjs';
import { Product } from 'src/environments/models/Product.model';
import { ProductService } from '../product.service';

@Component({
  selector: 'app-context',
  templateUrl: './context.component.html',
  styleUrls: ['./context.component.css']
})
export class ContextComponent implements OnInit {

  constructor(private productService: ProductService) { 
    ContextComponent.yourString.subscribe(res => {
      let array = res.split(',');
      this.productType = array[1];
      this.products = productService.GetProducts(Number(array[0]));
  });
  }
@Input() productType:String;
@Input() products:Product[];
public static yourString: Subject<String> = new Subject<String>();
  ngOnInit(): void {
  }

}
