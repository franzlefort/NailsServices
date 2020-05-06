import { Component, OnInit } from '@angular/core';
import {BranchApiService} from "./branch-api.service";
import { Branch } from './models/branch';
import {CommonApiService} from "../template/common-api.service";

@Component({
  selector: 'app-branch',
  templateUrl: 'branch.component.html',
  styles: [
  ]
})
export class BranchComponent implements OnInit {

  constructor(
      private _branchApiService: CommonApiService<Branch>
  ) { }

  ngOnInit(): void {
    const url: string = 'Branch/GetAll';
    this._branchApiService.getAllModels(url).subscribe(data => {
          this.branches = data;
        },
        error => {
          console.log(error)
        });
  }

  public branches?: Branch[];

  public getAllBranches() {

  }

}
