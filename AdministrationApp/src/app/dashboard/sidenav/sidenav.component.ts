import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sidenav',
  templateUrl: 'sidenav.component.html',
  styleUrls: ['sidenav.component.scss']
})
export class SidenavComponent implements OnInit {

  constructor() { }

  public menuItems: string[] = [
      'Добавить работника',
      'Добавить филиал',
      'Добавить должность'
  ];

  ngOnInit(): void {
  }

}
