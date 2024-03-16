import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-testapi',
  templateUrl: './testapi.component.html',
  styleUrls: ['./testapi.component.css']
})
export class TestapiComponent {
  public names: string[] = [];
  public ages: number[] = [];
  public dataLoaded: boolean = false;

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

  fetchData() {
    // make a HTTP request to fetch names from the API
    this.http.get<string[]>(`${this.baseUrl}Basic/names`).subscribe(
      result => {
        this.names = result; // assign the retrieved names to the 'names' property
        this.dataLoaded = true; // indicate that data has been loaded
      },
      error => {
        console.error(error); // handle errors gracefully (e.g., display error message)
      }
    );

    // make a HTTP request to fetch ages from the API
    this.http.get<number[]>(`${this.baseUrl}Basic/ages`).subscribe(
      result => {
        this.ages = result; // assign the retrieved ages to the 'ages' property
      },
      error => {
        console.error(error); // handle errors gracefully (e.g., display error message)
      }
    );
  }
}
