import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-react',
  templateUrl: './react.component.html',
  styleUrls:['./react.component.css']
})
export class ReactComponent {
  projects = [
    {name: "Weather App", src: "weather.png", link:"#"},
    {name: "Retail Phone Store", src: "retail.png", link:"#"},
    {name: "To Do List", src: "todo.png", link:"#"},
  ]
}
