import { Component } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'home',
    templateUrl: './home.component.html'
})
export class HomeComponent {
    public statistics: StatsEntry[];

    constructor(http: Http) {
        http.get('/api/Statistics/PlayerStatistics').subscribe(result => {
            this.statistics = result.json() as StatsEntry[];
        });
    }
}

interface StatsEntry {
    name: string;
    unique: string;
    tks: number;
    damage: number;
    deaths: number;
    kills: number;
    shots: number;
    hits: number;
    hs: number;
    bDefusions: number;
    bDefused: number;
    bPlants: number;
    bExplosions: number;
}
