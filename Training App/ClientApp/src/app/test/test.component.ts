import { Component } from '@angular/core';

@Component({
  selector: 'app-test',
  templateUrl: './test.component.html',
  styleUrls: ['./test.component.css']
})
export class TestComponent {
  toggleChanged(event: any) {
    if (event.checked) {
      alert("You toggled the switch on!");
    }
    else {
      alert("You toggled the switch off!");
    }
  }
}
