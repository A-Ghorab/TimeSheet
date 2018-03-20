import { Component } from '@angular/core';

@Component({
    selector: 'counter',
    templateUrl: './counter.component.html'
})
export class CounterComponent {
    public currentCount: number = 0;

    public incrementCounter() {
        this.currentCount++;
    }
}
