import { Component, OnInit, Input } from "@angular/core";

@Component({
  selector: "app-options",
  templateUrl: "./options.component.html",
  styleUrls: ["./options.component.css"]
})
export class OptionsComponent implements OnInit {
  @Input() catData;

  @Input() options = [
    {
      name: "Hunger",
      actions: ["Milk", "Fish", "Sardines"]
    },
    {
      name: "Health",
      actions: ["Doctor", "Massage", "Pray"]
    },
    {
      name: "PlayTime",
      actions: ["Fetch", "Laser", "Chase", "Wand"]
    },
    {
      name: "Clean",
      actions: ["Shower", "Brush"]
    },
    {
      name: "Sleep",
      actions: ["Nap", "Full"]
    }
  ];

  constructor() {}

  ngOnInit() {}
}
