import { Injectable } from "@angular/core";
import { getLocaleDateFormat } from "@angular/common";
import { HttpClient, HttpErrorResponse } from "@angular/common/http";

import { catchError, retry } from "rxjs/operators";

@Injectable({
  providedIn: "root"
})
export class CatDataService {
  dataUrl = "/cat";

  constructor(private http: HttpClient) {}

  getData() {
    return this.http
      .get(this.dataUrl)
      .pipe(retry(3), catchError(this.handleError));
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
