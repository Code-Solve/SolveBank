import { Component, OnInit } from '@angular/core';
import { FooterRightsComponent } from '../../components/footer-rights/footer-rights.component';
import { FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { Router } from '@angular/router';
import { NgxMaskDirective, NgxMaskPipe } from 'ngx-mask';
import { CommonModule } from '@angular/common';
import { UsuarioService } from '../../services/usuario.service';

@Component({
    selector: 'app-login',
    standalone: true,
    imports: [CommonModule, FooterRightsComponent, ReactiveFormsModule, NgxMaskPipe, NgxMaskDirective],
    templateUrl: './login.component.html',
    styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit  {
   
    session = localStorage.getItem('user') ? JSON.parse(localStorage.getItem('user')!) : null;
    ngOnInit(): void {
        
        if (this.session != null) {
            this._route.navigate(['/home'])
        }
    }

    loginForm: FormGroup;

    constructor(private _http: HttpClient, private _route: Router, private usuarioServices:UsuarioService) {
        this.loginForm = new FormGroup({
            cpf: new FormControl('', [Validators.required, Validators.pattern(/^\d{3}\.\d{3}\.\d{3}-\d{2}$/)]),
            senha: new FormControl('', Validators.required),
            lembrar: new FormControl(false)
        });
    }

    submitForm() {
    
        this._http.get<any>('http://localhost:3000/users').subscribe(res => {
            const user = res.find((u: any) => { return u.cpf === this.loginForm.value.cpf && u.senha === this.loginForm.value.senha })
            if (user) {
                alert('Login efetuado com sucesso!')
                localStorage.setItem('user', JSON.stringify(user))
                this.loginForm.reset()
                this._route.navigate(['/home'])
            } else {
                alert('Usuario ou senha incorretos!')
            }
        })

    }
}
