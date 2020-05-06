import { Injectable } from '@angular/core';
import {ApiService} from "../../../Shared/Services/api.service";
import {Branch} from "../branch/models/branch";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CommonApiService<TModel> {

  constructor(
      private _apiService: ApiService
  ) {
  }

  public getAllModels(apiUrl: string): Observable<TModel[]> {
    return <Observable<TModel[]>> this._apiService.GetModel(apiUrl);
  }
}
