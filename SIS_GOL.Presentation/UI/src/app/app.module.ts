
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { FormCadastarComponent } from './formCadastar/formCadastar.component';
import { GridResultComponent } from './gridResult/gridResult.component';
import { ReactiveFormsModule } from '@angular/forms';
import { DataFornatPipe } from './Util/DataFornat.pipe';
@NgModule({
  declarations: [
    AppComponent,

    //  BsDatepickerModule.forRoot(),
    // ModalModule.forRoot(),
    // TooltipModule.forRoot(),
    FormCadastarComponent,
    GridResultComponent,
    DataFornatPipe
  ],
  imports: [BrowserModule, HttpClientModule, ReactiveFormsModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
