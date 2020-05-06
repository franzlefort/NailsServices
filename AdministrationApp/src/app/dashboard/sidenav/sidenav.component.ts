import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-sidenav',
  templateUrl: 'sidenav.component.html',
  styleUrls: ['sidenav.component.scss']
})
export class SidenavComponent implements OnInit {

  constructor() { }

  public menuItems: MenuItem[] = [
      {name: 'Добавить филиал', link: 'branch-management'},
      {name: 'Добавить должность', link: 'post-management'},
      {name: 'Добавить сотрудника', link: 'employee-management'},
      {name: 'Template', link: 'template-management'},
  ];

  ngOnInit(): void {
  }

}

export class MenuItem {
    name: string;
    link: string;
}
