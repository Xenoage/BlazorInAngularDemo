import { Injectable } from '@angular/core';
import { UserService } from './user.service';

/**
 * In this service, we expose required Angular service methods to Blazor
 * by making them available in a "window.BlazorBridge" object.
 *
 * Don't forget to inject this service somewhere (like in app.component.ts)
 * so that it gets initialized!
 */
@Injectable()
export class BlazorBridgeService {

  public constructor(userService: UserService) {
    // Exposed methods:
    const blazorBridge = {
      getCurrentUser: userService.getCurrentUser.bind(userService)
    };
    (window as any).BlazorBridge = blazorBridge;
    console.debug("Angular service methods exposed: ", blazorBridge);
  }

}
