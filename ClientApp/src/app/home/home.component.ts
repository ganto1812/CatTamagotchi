import { Component } from "@angular/core";
import { CatData, CatDataService } from "./../cat-data.service";
import { threadId } from "worker_threads";

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html"
})
export class HomeComponent {
  error: any;
  catData: CatData;

  constructor(private catDataService: CatDataService) {}

  ngOnInit() {
    this.showCatData();
  }

  showCatData() {
    let data = this.catDataService.getData();
    data.subscribe(
      (data: CatData) =>
        (this.catData = {
          name: data["name"],
          hunger: data["hunger"],
          health: data["health"],
          playTime: data["playTime"],
          clean: data["clean"],
          sleep: data["sleep"],
          lastAction: data["lastAction"]
        }),
      error => (this.error = error)
    );
  }
}
