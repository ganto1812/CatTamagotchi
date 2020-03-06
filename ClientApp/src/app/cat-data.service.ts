import { Injectable } from "@angular/core";
import { HttpClient, HttpErrorResponse } from "@angular/common/http";

import { catchError, retry } from "rxjs/operators";

export interface CatData {
  name: string;
  hunger: number;
  health: number;
  playTime: number;
  clean: number;
  sleep: number;
  lastAction: string;
}

@Injectable({
  providedIn: "root"
})
export class CatDataService {
  dataUrl = "/cat";

  constructor(private http: HttpClient) {}

  getData() {
    return this.http.get<CatData>(this.dataUrl).pipe(retry(3));
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      console.error("An error occurred:", error.error.message);
    } else {
      console.error(
        `Backend returned code${error.status}, ` + `body was: ${error.error}`
      );
    }
  }
}
