// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

import { Inject, Injectable } from "@angular/core";

class urlserwis {
  public static baseUrl: string;

  constructor(@Inject('BASE_URL') public baseUrl: string) {
    this.baseUrl = baseUrl;    
  }
}

export const environment = {
  // Inject('BASE_URL') private baseUrl: string
  production: false,
  api: {
    path: 'api' //@Inject('BASE_URL') private baseUrl: string
  }  
};

/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
