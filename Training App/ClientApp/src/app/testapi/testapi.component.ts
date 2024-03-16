import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-testapi',
  templateUrl: './testapi.component.html',
  styleUrls: ['./testapi.component.css']
})
export class TestapiComponent {
  public datas: ApiTestData[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<ApiTestData[]>(baseUrl + 'Basic/name').subscribe(result => {
      this.datas = result;
    }, error => console.error(error));
  }
}

interface ApiTestData {
  name: string;
}
