import { BrowserModule } from "@angular/platform-browser";
import { NgModule } from "@angular/core";
import { FormsModule } from "@angular/forms";
import { HttpClientModule, HTTP_INTERCEPTORS } from "@angular/common/http";
import { RouterModule } from "@angular/router";

import { AppComponent } from "./app.component";
import { NavMenuComponent } from "./nav-menu/nav-menu.component";
import { HomeComponent } from "./home/home.component";
import { VanillaJSComponent } from "./vanillaJS/vanillaJS.component";
import { ReactComponent } from "./react/react.component";
import { AngularComponent } from "./angular/angular.component";
import { StatsComponent } from "./angular/stats/stats.component";
import { StatComponent } from "./angular/stats/stat/stat.component";
import { OptionsComponent } from "./angular/options/options.component";
import { ActionOptionsComponent } from "./angular/options/action-options/action-options.component";
import { OptionComponent } from "./angular/options/action-options/option/option.component";
import { FooterComponent } from "./footer/footer.component";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    VanillaJSComponent,
    ReactComponent,
    AngularComponent,
    StatsComponent,
    StatComponent,
    OptionsComponent,
    ActionOptionsComponent,
    OptionComponent,
    FooterComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: "ng-cli-universal" }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: "", component: HomeComponent, pathMatch: "full" },
      { path: "vanillaJS", component: VanillaJSComponent },
      { path: "react", component: ReactComponent },
      { path: "angular", component: AngularComponent }
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {}
