import { Injectable } from '@angular/core';
import { Usuario } from '../models/Usuario/Usuario';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { usuarioLoginDTO } from '../models/DTOs/UsuarioDTOs/usuarioLoginDTO';
import { responseExibirUsuarioDTO } from '../models/DTOs/UsuarioDTOs/responseExibirUsuarioDTO';
import { uri } from './uriGlobalAcess';
@Injectable({
  providedIn: 'root'
})
export class UsuarioService {
  constructor(private httpRequest: HttpClient) { }
  

  cadastraUsuario(usuarioCadastro: Usuario): Observable<string> {
    return this.httpRequest.post<string>(`${uri}usuario/cadastrar/`, usuarioCadastro).pipe(
      res => res,
      error => error
    )
  }
  loginUsuario(usuarioLogin: usuarioLoginDTO): Observable<any> {
    return this.httpRequest.post<any>(`${uri}usuario/login/`, usuarioLogin).pipe(
      res => res,
      error => error
    )
  }
  autenticarUsuario(token2Fatores: string):Observable<any> {
    return this.httpRequest.get<any>(`${uri}usuario/autenticar/${token2Fatores}`).pipe(
      res => res,
      error => error
    )
  }
}



