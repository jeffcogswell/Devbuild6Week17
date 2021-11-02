import { Component } from '@angular/core';

@Component({
    selector: 'app-my-demo',
    templateUrl: './my-demo.component.html',
    styleUrls: ['./my-demo.component.css']
})
/** MyDemo component*/
export class MyDemoComponent {
    /** MyDemo ctor */
    constructor() {
      console.log('THIS IS ONLY A TEST');
    }
}
