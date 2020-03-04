import { Component, OnInit } from "@angular/core";
import { CatData, CatDataService } from "./../../cat-data.service";

@Component({
  selector: "app-stats",
  templateUrl: "./stats.component.html",
  styleUrls: ["./stats.component.css"]
})
export class StatsComponent implements OnInit {
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
