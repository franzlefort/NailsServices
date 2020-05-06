import { Component, OnInit, Input } from '@angular/core';
import {CommonApiService} from "./common-api.service";
import {Branch} from "../branch/models/branch";

@Component({
  selector: 'app-template',
  templateUrl: 'template.component.html',
  styleUrls: ['template.component.scss']
})
export class TemplateComponent<TModel> implements OnInit {

  constructor(
      private _apiService: CommonApiService<Branch>
  ) { }

  @Input()
  public getAllUrl: string = 'Branch/GetAll';
  ngOnInit(): void {
    this._apiService.getAllModels(this.getAllUrl).subscribe(data => {
          this.models = data;
        },
        error => {
          console.log(error)
        });
  }

  public models: Branch[];

  displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
  dataSource = ELEMENT_DATA;
}

export interface PeriodicElement {
  name: string;
  position: number;
  weight: number;
  symbol: string;
}

const ELEMENT_DATA: PeriodicElement[] = [
  {position: 1, name: 'Hydrogen', weight: 1.0079, symbol: 'H'},
  {position: 2, name: 'Helium', weight: 4.0026, symbol: 'He'},
  {position: 3, name: 'Lithium', weight: 6.941, symbol: 'Li'},
  {position: 4, name: 'Beryllium', weight: 9.0122, symbol: 'Be'},
  {position: 5, name: 'Boron', weight: 10.811, symbol: 'B'},
  {position: 6, name: 'Carbon', weight: 12.0107, symbol: 'C'},
  {position: 7, name: 'Nitrogen', weight: 14.0067, symbol: 'N'},
  {position: 8, name: 'Oxygen', weight: 15.9994, symbol: 'O'},
  {position: 9, name: 'Fluorine', weight: 18.9984, symbol: 'F'},
  {position: 10, name: 'Neon', weight: 20.1797, symbol: 'Ne'},
];
