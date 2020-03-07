import { Injectable } from "@angular/core";
import { HttpClient, HttpErrorResponse } from "@angular/common/http";

import { catchError, retry } from "rxjs/operators";
import { Observable, throwError } from "rxjs";

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
    return this.http
      .get<CatData>(this.dataUrl)
      .pipe(retry(3), catchError(this.handleError));
  }

  private handleError(error: HttpErrorResponse) {
    if (error.error instanceof ErrorEvent) {
      //Client-side error
      console.error("An error occurred:", error.error.message);
    } else {
      //Backend error
      console.error(
        `Backend returned code${error.status}, ` + `body was: ${error.error}`
      );
    }
    //Return observable with user-facing error
    return throwError("Something bad happened :( Please try again later.");
  }
}
