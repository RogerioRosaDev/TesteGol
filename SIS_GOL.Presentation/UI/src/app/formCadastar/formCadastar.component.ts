import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';

import { AirplaneService } from '../Services/Airplane.service';
import { AirplaneVM } from '../Entidades/AirplaneVM';

@Component({
  selector: 'app-formCadastar',
  templateUrl: './formCadastar.component.html',
  styleUrls: ['./formCadastar.component.css']
})
export class FormCadastarComponent implements OnInit {
  constructor(
    private formBuilder: FormBuilder,
    private airSevice: AirplaneService
  ) {}
  lstAirplane: AirplaneVM[];
  formCadastro: FormGroup;
  airplane: AirplaneVM;
  modoTela: string;
  ngOnInit() {
    this.formCadastro = this.formBuilder.group({
      idAviao: 0,
      codigoAviao: [
        '',
        [Validators.required, Validators.minLength(1), Validators.maxLength(10)]
      ],
      modeloAviao: [
        '',
        [
          Validators.required,
          Validators.minLength(2),
          Validators.maxLength(100)
        ]
      ],
      qtdPassageiros: [null, [Validators.required, Validators.max(300)]],
      dataCriacao: [null, Validators.required]
    });
    this.formCadastro.reset();
    this.getFindAll();
    this.modoTela = 'post';
  }
  getFindAll() {
    return this.airSevice.getAirplaneFindAll().subscribe(
      res => {
        this.lstAirplane = res;
        this.modoTela = 'post';
      },
      error => {
        console.log(error);
      }
    );
  }
  getalterAir(id: number) {
    return this.airSevice.getAirplaneFindOne(id).subscribe(
      r => {
        this.airplane = r;
        console.log(this.airplane);
        this.formCadastro.patchValue(this.airplane);
        this.modoTela = 'put';
      },
      error => {
        console.log(error);
      }
    );
  }

  deleteAir(id: number) {
    const result = confirm('Deseja Realmente excluir esse registro?');
    if (result) {
      this.airSevice.Delete(id).subscribe(
        () => {
          this.getFindAll();
        }
      );
    }
  }
  Salvar() {
    if (this.formCadastro.valid && this.modoTela === 'post') {
      this.airplane = Object.assign({}, this.formCadastro.value);
      this.airplane.idAviao = 0;
      this.airSevice.Create(this.airplane).subscribe(
        (air: AirplaneVM) => {
          this.formCadastro.reset();
          this.getFindAll();
        },
        error => {
          console.log(error);
        }
      );
    } else {
      if (this.formCadastro.valid  && this.modoTela === 'put') {
        this.airplane = Object.assign({}, this.formCadastro.value);
         console.log(this.airplane.idAviao);
        this.airSevice.Update(this.airplane).subscribe(
          (air: AirplaneVM) => {
            this.formCadastro.reset();
            this.getFindAll();
          },
          error => {
            console.log(error);
          }
        );
      }
    }
  }
}
