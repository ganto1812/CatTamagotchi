import { Component } from '@angular/core';

@Component({
  selector: 'app-vanillaJS-component',
  templateUrl: './vanillaJS.component.html',
  styleUrls: ["vanillaJS.component.css"]
})
export class VanillaJSComponent {
  projects = [
    {name: "Tribute Page", src: "tribute.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/tributepage/"},
    {name: "Drum Set", src: "drum.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/drums"},
    {name: "Clock", src: "clock.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/clock"},
    {name: "Draw!", src: "draw.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/draw/"},
    {name: "Live Editing", src: "liveUpdate.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/liveupdate/"},
    {name: "Flex Panels", src: "flexPanels.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/flexpanels/"},
    {name: "Mouse Effect", src: "mouseEffects.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/mouseeffects/"},
    {name: "Search bar", src: "searchBar.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/searchbar/"},
    {name: "Slide Effect", src: "slideEffect.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/slideeffect/"},
    {name: "Tapas List", src: "tapasList.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/tapaslist/"},
    {name: "Pick a Voice", src: "voiceChanger.jpg", link:"https://thirsty-dijkstra-45a951.netlify.app/voicechanger/"}
  ]
}
