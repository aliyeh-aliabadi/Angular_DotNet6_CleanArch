import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ServerLogsService {
  private headers: HttpHeaders;
  private accessPointUrl: string = 'https://localhost:7201/ServerLogs';


  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({ 'Content-Type': 'application/json; charset=utf-8' });
  }

  public get() {
    //Get all ServerLogs data
     return this.http.get(this.accessPointUrl, { headers: this.headers });
  }
}
