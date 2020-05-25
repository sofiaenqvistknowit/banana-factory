import { Injectable } from '@angular/core';
import { Product } from 'src/environments/models/Product.model';
import { ProductType } from 'src/environments/models/ProductType.model';

@Injectable({
  providedIn: 'root'
})
export class ProductService {

  // GetProductTypes(): string[] {
  //   return ["APA","ÄTER","HALLONEN","BANANERNA","ÄR", "DET","INGEN", "SOM","ÄTER"];
  // }


  GetProductTypes(): any {
    //return ["APA","ÄTER","HALLONEN","BANANERNA","ÄR", "DET","INGEN", "SOM","ÄTER"];
    return this.myProductTypes;
  }


  public myProductTypes:Array<ProductType> = [
    {
      ProductTypeId:1,
      ProductType:"El & TV"
    },
    {
      ProductTypeId:2,
      ProductType:"Frukter"
    },
    {
      ProductTypeId:3,
      ProductType:"Mejeri"
    },
    {
      ProductTypeId:4,
      ProductType:"Chark"
    },
    {
      ProductTypeId:5,
      ProductType:"Godis"
    }];

  public myProducts:Array<Product> = [
    {
      ProductId:1,
      ImageId: 1,
      SupplierId: 1,
      ProductTypeId: 1,
      Name: "Samsung Q7",
      Color: "Svart",
      Size: "55'",
      Weight: "25 kg",
      Price: "8998 kr"
    },{
      ProductId:2,
      ImageId: 2,
      SupplierId: 2,
      ProductTypeId: 2,
      Name: "Fyffes",
      Color: "Gula",
      Size: "25 cm",
      Weight: "23 kilo",
      Price: "10 kr/kg"
    },
    {
      ProductId:3,
      ImageId: 3,
      SupplierId: 3,
      ProductTypeId: 3,
      Name: "Arla Mjölk",
      Color: "Vit",
      Size: "1 liter",
      Weight: "1 kg",
      Price: "18 kr/liter"
    },
    {
      ProductId:4,
      ImageId: 4,
      SupplierId: 1,
      ProductTypeId: 1,
      Name: "LG LED",
      Color: "Vit",
      Size: "75'",
      Weight: "32 kg",
      Price: "20000kr"
    },
    {
      ProductId:5,
      ImageId: 5,
      SupplierId: 3,
      ProductTypeId: 2,
      Name: "Jaffa Apelsiner",
      Color: "Orangea",
      Size: "25 cm",
      Weight: "28 kg",
      Price: "11 kr/kg"
    },
    {
      ProductId:6,
      ImageId: 6,
      SupplierId: 3,
      ProductTypeId: 3,
      Name: "Arla Grädde",
      Color: "Vit",
      Size: "33 cl",
      Weight: "0,33 kg",
      Price: "27 kr/liter"
    },
    {
      ProductId:7,
      ImageId: 7,
      SupplierId: 1,
      ProductTypeId: 1,
      Name: "Apple TV",
      Color: "Vit",
      Size: "32'",
      Weight: "16",
      Price: "4500kr"
    },{
      ProductId:8,
      ImageId: 8,
      SupplierId: 2,
      ProductTypeId: 2,
      Name: "Chiquita Bananer",
      Color: "Bruna",
      Size: "Omkrets: 12 cm",
      Weight: "29 kilo",
      Price: "32 kr/kg"
    },
    {
      ProductId:9,
      ImageId: 9,
      SupplierId: 3,
      ProductTypeId: 3,
      Name: "Bregott",
      Color: "Gult",
      Size: "500 g",
      Weight: "80 kg",
      Price: "36 kr/kilo"
    },
    {
      ProductId:10,
      ImageId: 10,
      SupplierId: 5,
      ProductTypeId: 1,
      Name: "Samsung Q6",
      Color: "Svart",
      Size: "55'",
      Weight: "25 kg",
      Price: "8000kr"
    },{
      ProductId:11,
      ImageId: 11,
      SupplierId: 2,
      ProductTypeId: 2,
      Name: "Jaffa Päron",
      Color: "Gröna",
      Size: "12 cm",
      Weight: "128 kilo",
      Price: "2 kr/kg"
    },
    {
      ProductId:12,
      ImageId: 12,
      SupplierId: 3,
      ProductTypeId: 3,
      Name: "Yoggi",
      Color: "Vit",
      Size: "1 liter",
      Weight: "1 kg",
      Price: "25 kr/liter"
    },
    {
      ProductId:13,
      ImageId: 13,
      SupplierId: 5,
      ProductTypeId: 4,//Chark
      Name: "Scan Fläskfile",
      Color: "Röd",
      Size: "35 cm",
      Weight: "95 kg",
      Price: "120kr/kg"
    },{
      ProductId:14,
      ImageId: 14,
      SupplierId: 2,
      ProductTypeId: 5,//Godis
      Name: "Algrens bilar",
      Color: "Vit, Rosa, Grön",
      Size: "12x12 cm",
      Weight: "128 kilo",
      Price: "14 kr/påse"
    },
    {
      ProductId:15,
      ImageId: 15,
      SupplierId: 3,
      ProductTypeId: 5,
      Name: "Marabou schweizernöt",
      Color: "brun",
      Size: "500 g",
      Weight: "100 kg",
      Price: "25 kr/kaka"
    },{
      ProductId:16,
      ImageId: 16,
      SupplierId: 4,
      ProductTypeId: 5,//Godis
      Name: "Bumlingar",
      Color: "Vit, Rosa, Grön",
      Size: "12x12 cm",
      Weight: "220 kilo",
      Price: "6 kr/kg"
    },
    {
      ProductId:17,
      ImageId: 17,
      SupplierId: 4,
      ProductTypeId: 4,
      Name: "Rebensspjäll",
      Color: "brun",
      Size: "250 g",
      Weight: "180 kg",
      Price: "120 kr/kg"
    },
    {
      ProductId:18,
      ImageId: 18,
      SupplierId: 4,
      ProductTypeId: 4,
      Name: "Oxfile",
      Color: "brun",
      Size: "220 g",
      Weight: "197 kg",
      Price: "130 kr/kg"
    }
  ]
  GetProducts(id:number): any {
    return this.myProducts.filter(x => x.ProductTypeId === id);
  }

  constructor() { }
}
