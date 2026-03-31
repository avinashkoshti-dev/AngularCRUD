import { bootstrapApplication } from '@angular/platform-browser';
import { appConfig } from './app/app.config';
import { AppComponent } from './app/app.component';


bootstrapApplication(AppComponent, appConfig)
 .catch((err) => console.error(err));

//   bootstrapApplication(AppComponent, {
//   providers: [provideHttpClient()]
//   });
// function provideHttpClient(): import("@angular/core").Provider | import("@angular/core").EnvironmentProviders {
//   throw new Error('Function not implemented.');
// }

