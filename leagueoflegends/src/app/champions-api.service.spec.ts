import { TestBed } from '@angular/core/testing';

import { ChampionsApiService } from './champions-api.service';
import { Champion } from './champion-model';

describe('ChampionsApiService', () => {
  let service: ChampionsApiService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ChampionsApiService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should get the first two champions', () => {
    
    const expectedChampions: Champion[] = [{
      "version": "6.24.1",
      "id": "Aatrox",
      "key": "266", 
      "name": "Aatrox", 
      "title": "La Espada de los Oscuros", 
      "blurb": "Aatrox es un guerrero legendario, uno de los únicos cinco que quedan de una raza antigua conocida como 'Los Oscuros'. Porta su enorme espada con gracia y serenidad, y la desliza entre sus enemigos con un estilo hipnótico y terrible. Tras derribar a ...", 
      "info": { 
        "attack": 8, 
        "defense": 4, 
        "magic": 3, 
        "difficulty": 4 
      },
      "image": { 
        "full": "Aatrox.png", 
        "sprite": "champion0.png", 
        "group": "champion", 
        "x": 0, 
        "y": 0, 
        "w": 48, 
        "h": 48 }, 
        "tags": ["Fighter", "Tank"], 
        "partype": "BloodWell", 
        "stats": { 
          "hp": 537.8, 
          "hpperlevel": 85.0, 
          "mp": 105.6, 
          "mpperlevel": 45.0, 
          "movespeed": 345.0, 
          "armor": 24.384, 
          "armorperlevel": 3.8, 
          "spellblock": 32.1, 
          "spellblockperlevel": 1.25, 
          "attackrange": 150.0, 
          "hpregen": 6.59, 
          "hpregenperlevel": 0.5, 
          "mpregen": 0.0, 
          "mpregenperlevel": 0.0, 
          "crit": 0.0, 
          "critperlevel": 0.0, 
          "attackdamage": 60.376, 
          "attackdamageperlevel": 3.2, 
          "attackspeedoffset": -0.04, 
          "attackspeedperlevel": 3.0
        }
    },
    {
      "version":"6.24.1","id":"Ahri","key":"103","name":"Ahri","title":"La Mujer Zorro de nueve Colas","blurb":"A diferencia de otros zorros que habitan en los bosques al sur de Jonia, Ahri siempre sintió una extraña conexión con el mundo mágico que la rodeaba. Una conexión que, de algún modo, le parecía que estaba incompleta. En lo más profundo de su interior, ...","info":{"attack":3,"defense":4,"magic":8,"difficulty":5},"image":{"full":"Ahri.png","sprite":"champion0.png","group":"champion","x":48,"y":0,"w":48,"h":48},"tags":["Mage","Assassin"],"partype":"MP","stats":{"hp":514.4,"hpperlevel":80.0,"mp":334.0,"mpperlevel":50.0,"movespeed":330.0,"armor":20.88,"armorperlevel":3.5,"spellblock":30.0,"spellblockperlevel":0.0,"attackrange":550.0,"hpregen":6.505,"hpregenperlevel":0.6,"mpregen":6.0,"mpregenperlevel":0.8,"crit":0.0,"critperlevel":0.0,"attackdamage":53.04,"attackdamageperlevel":3.0,"attackspeedoffset":-0.065,"attackspeedperlevel":2.0
        }
    }]

    service.getChampions().subscribe((champions) => {
      expect(champions).toBe(expectedChampions);
    })

  });

});