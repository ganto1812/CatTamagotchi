import { Component } from "@angular/core";
import { CatData, CatDataService } from "../cat-data.service";

@Component({
  selector: "app-angular",
  templateUrl: "./angular.component.html"
})
export class AngularComponent {
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
        })
    );
  }
}
