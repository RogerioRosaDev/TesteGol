import { AirplaneVM } from '../Entidades/AirplaneVM';
import { Component, OnInit } from '@angular/core';
import { AirplaneService } from '../Services/Airplane.service';

@Component({
  selector: 'app-gridResult',
  templateUrl: './gridResult.component.html',
  styleUrls: ['./gridResult.component.css']
})
export class GridResultComponent implements OnInit {
  lstAirplane: AirplaneVM[];
  airplane: AirplaneVM;
  constructor(private airplaneService: AirplaneService) {}

  ngOnInit() {
    this.getFindAll();
  }

  getFindAll() {
    return this.airplaneService.getAirplaneFindAll().subscribe(
      res => {
        this.lstAirplane = res;
      },
      error => {
        console.log(error);
      }
    );
  }
  alterAir(id: number) {
    return this.airplaneService.getAirplaneFindOne(id).subscribe(
      r => {
        this.airplane = r;
        console.log(this.airplane);
      },
      error => {
        console.log(error);
      }
    );
  }
  deleteAir(id: number) {
    const result = confirm('Deseja Realmente excluir esse registro?');
    if (result) {
      this.airplaneService.Delete(id);
    }
  }
}
