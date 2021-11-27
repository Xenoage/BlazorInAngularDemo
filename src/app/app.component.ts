import { Component, OnInit } from "@angular/core";

import { UserService, BlazorBridgeService } from "./core";

@Component({
  selector: "app-root",
  templateUrl: "./app.component.html",
})
export class AppComponent implements OnInit {
  constructor(private userService: UserService,
    private blazorBridgeService: BlazorBridgeService /* initialize Blazor service bridge */) {}

  ngOnInit() {
    this.userService.populate();
  }
}
