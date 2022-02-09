import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Champion } from './champion-model';

@Injectable({
  providedIn: 'root'
})
export class ChampionsApiService {
  
  getChampions() : Observable<Champion[]> {
    let champion : Champion[] = [];
    return of(champion);
  }

  constructor() { }
}
