import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router';
import { Product } from '../product';

@Component({
  selector: 'app-product-add',
  templateUrl: './product-add.component.html',
  styleUrls: ['./product-add.component.css']
})
export class ProductAddComponent implements OnInit {
  item: Product;
  pid: number;
  pname: string;
  price: number;
  stock: number;
  //emplist:Product[] = [];
  constructor(private router:Router) {
    this.item = new Product();
  }

  ngOnInit(): void {
  }
  Add() {
    this.item = {
      pid: this.pid,
      pname: this.pname,
      price: this.price,
      stock: this.stock
    };
    //this.emplist.push(this.item);
    localStorage.setItem("item", this.item.toString())
    this.router.navigateByUrl('product-view')
  }

}
