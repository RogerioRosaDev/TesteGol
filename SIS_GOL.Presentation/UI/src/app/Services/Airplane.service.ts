

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { AirplaneVM } from '../Entidades/AirplaneVM';
@Injectable({
  providedIn: 'root'
})
export class AirplaneService {
  private urlBase = 'https://localhost:5001/api/Airplane';
  constructor(private http: HttpClient) {}

  getAirplaneFindAll(): Observable<AirplaneVM[]> {
    return this.http.get<AirplaneVM[]>(this.urlBase);
  }

  getAirplaneFindOne(id: number): Observable<AirplaneVM> {
    return this.http.get<AirplaneVM>(`${this.urlBase}/Alter/${id}`);
  }
  Update(entidade: AirplaneVM) {
    return this.http.put(`${this.urlBase}/Alter`, entidade);
  }
  Create(entidade: AirplaneVM) {
    console.log('Chegou aqui');
    return this.http.post(`${this.urlBase}/Create`, entidade);
  }
  Delete(id: number) {
     return this.http.delete(`${this.urlBase}/Delete/${id}`);
  }
}
