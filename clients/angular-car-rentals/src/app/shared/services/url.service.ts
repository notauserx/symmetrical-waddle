import { environment } from '../../../environments/environment'
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class UrlService {

  public baseUrl: string = environment.baseUrl;

  constructor() { }
}
