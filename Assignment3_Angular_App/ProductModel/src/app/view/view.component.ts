import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';

@Component({
  selector: 'app-view',
  templateUrl: './view.component.html',
  styleUrls: ['./view.component.css']
})
export class ViewComponent implements OnInit {

  list: Employee[]
  constructor() {
    this.list = [
      { eid: 1, ename: 'Priyanka', desig: 'Software Engineer', joindate: new Date(2020, 8, 17), salary: 160000 },
      { eid: 2, ename: 'Madhumitha', desig: 'Intern', joindate: new Date(2020, 8, 17), salary: 12000 },
      { eid: 3, ename: 'Sushanth', desig: 'CEO', joindate: new Date(2020, 8, 17), salary: 1500000 },
    ]
  }

  ngOnInit(): void {
  }

}
