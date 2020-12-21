import { Component, OnInit, Input } from "@angular/core";

@Component({
  selector: "app-action-options",
  templateUrl: "./action-options.component.html",
  styleUrls: ["./action-options.component.css"]
})
export class ActionOptionsComponent implements OnInit {
  @Input() option;
  @Input() catData;

  constructor() {}

  ngOnInit() {}

  action(action) {
    switch (action) {
      case 'food':
        
        break;
    
      case 'health':
        
        break;
    
      case 'play':
        
        break;
    
      case 'shower':
        
        break;
    
      case 'sleep':
        
        break;
    
      default:
        break;
    }
  }
}
