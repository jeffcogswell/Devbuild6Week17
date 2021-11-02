import { HttpClient } from '@angular/common/http';
import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Instrument } from '../instrument';

@Component({
    selector: 'app-one-inst',
    templateUrl: './one-inst.component.html',
    styleUrls: ['./one-inst.component.css']
})
/** OneInst component*/
export class OneInstComponent {

	@Input() theinst: Instrument = null;
	@Output() deleteevent: EventEmitter<Number> = new EventEmitter<Number>();

    /** OneInst ctor */
    constructor(private http: HttpClient) {

	}

	deleteMe() {
		this.deleteevent.emit(this.theinst.id);
	}
}
