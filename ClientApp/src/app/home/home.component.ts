import { Component } from "@angular/core";

@Component({
  selector: "app-home",
  templateUrl: "./home.component.html",
  styleUrls: ["./home.component.css"]
})
export class HomeComponent {
  home = {
    langs:["html.png", "css.png", "js.png", "cSharp.png"],
    libs:["net.png", "jquery.png", "reactjs.png", "angular.png", "bootstrap.png", "sass.png"],
    designs:["photoshop.svg", "illustrator.jpg", "adobe-xd.svg", "gimp.png", "inkscape.png"],
    others: ["github.png", "slack.png", "icescrum.png", "figma.png"]
  }
  constructor() {}

  ngOnInit() {
  }

}
