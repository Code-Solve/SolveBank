import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-deposit',
  standalone: true,
  imports: [RouterModule, FormsModule, ReactiveFormsModule, CommonModule],
  templateUrl: './deposit.component.html',
  styleUrl: './deposit.component.css',
})
export class ExternalDepositComponent {
  agencia: string = '';
  conta: string = '';
  valor: string = '';

  constructor() {}

  limparCampos(): void {
    this.agencia = '';
    this.conta = '';
    this.valor = '';
  }
}
