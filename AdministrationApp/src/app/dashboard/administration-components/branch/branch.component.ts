import { Component, OnInit } from '@angular/core';
import {BranchApiService} from "./branch-api.service";
import { Branch } from './models/branch';

@Component({
  selector: 'app-branch',
  templateUrl: 'branch.component.html',
  styles: [
  ]
})
export class BranchComponent implements OnInit {

  constructor(
      private _branchApiService: BranchApiService
  ) { }

  ngOnInit(): void {
  }

  public branches: Branch[];

  public getAllBranches() {
    this._branchApiService.getAllBranches().subscribe(data => {
          this.branches = data;
        },
        error => {
          console.log(error)
        });
  }

}
