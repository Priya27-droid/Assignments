import { Component, OnInit } from '@angular/core';
import { Product } from '../product';

@Component({
  selector: 'app-product-view',
  templateUrl: './product-view.component.html',
  styleUrls: ['./product-view.component.css']
})
export class ProductViewComponent implements OnInit {
  item: Product;

  constructor() {
    this.item = JSON.parse((localStorage.getItem("item")));
  }

  ngOnInit(): void {
  }

}
