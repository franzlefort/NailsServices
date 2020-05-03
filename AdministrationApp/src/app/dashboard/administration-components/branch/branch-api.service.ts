import { Injectable } from '@angular/core';
import {Branch} from "./models/branch";
import {ApiService} from "../../../Shared/Services/api.service";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BranchApiService {

  constructor(
      private _apiService: ApiService
  ) {
  }

  public getAllBranches(): Observable<Branch[]> {
    const url: string = 'Branch/GetAll';
    return <Observable<Branch[]>> this._apiService.GetModel(url);
  }
}
