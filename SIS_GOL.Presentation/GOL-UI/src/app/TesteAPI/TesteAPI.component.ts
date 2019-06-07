import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-testeapi',
  templateUrl: './TesteAPI.component.html',
  styleUrls: ['./TesteAPI.component.css']
})
export class TesteAPIComponent implements OnInit {
  lstAir: any;
  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getListaAirplane();
  }

  getListaAirplane() {
    this.http.get('https://localhost:44390/api/values').subscribe(
      response => {
        this.lstAir = response;
        console.log(response);
      },
      error => {
        console.log(error);
      }
    );
  }
}
