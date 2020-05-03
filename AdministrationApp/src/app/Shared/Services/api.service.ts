import { Injectable } from '@angular/core';
import { HttpClient, HttpParams, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  private headers: HttpHeaders;

  constructor(
      private _httpClient: HttpClient
  ) {
    this.headers = new HttpHeaders();

    this.headers = this.headers
        .set('Access-Control-Allow-Origin', this.basePath)
        .set('Access-Control-Allow-Methods', 'GET, POST, OPTIONS, PUT, PATCH, DELETE')
        .set('Access-Control-Allow-Headers', "Origin, X-Requested-With, Content-Type, Accept");
  }

  private basePath: string = 'https://localhost:5001/api/';

  public GetModel(path: string, parameters: HttpParams = null): Observable<Object> {
    const fullPath: string = this.basePath + path;
    return this._httpClient.get(fullPath, {
      params: parameters,
      headers: this.headers
    });
  }

  public PostModel(model: any, path: string, parameters: HttpParams = null): Observable<Object> {
    const fullPath: string = this.basePath + path;
    return this._httpClient.post(fullPath, model, {
      params: parameters,
      headers: this.headers
    });
  }

  public DeleteModel(path: string, parameters: HttpParams = null): Observable<Object> {
    const fullPath: string = this.basePath + path;
    return this._httpClient.delete(fullPath, {
      params: parameters,
      headers: this.headers
    });
  }
}
