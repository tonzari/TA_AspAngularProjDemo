import { HttpClient } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class EventService {

  //API URL
  apiUrl: string = "sdfsdf";

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  getAllEvents(): any {
    return this.http.get(this.baseUrl + "Upmeet");
  }
}
