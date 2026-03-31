import { Routes } from '@angular/router';
import { StudComponent } from './stud/stud.component';

export const routes: Routes = [
  {
    path : '',
    redirectTo : 'stud',
    pathMatch : 'full'
  },
  { path: 'stud', component: StudComponent }
];
