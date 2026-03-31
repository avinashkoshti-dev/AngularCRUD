import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class StudentService {

 private baseUrl = 'https://localhost:7270/api/Stud';
  constructor(private http: HttpClient) {

   }
    getStudentList(): Observable<any> {
     return this.http.get(`${this.baseUrl}`);
  }

  createStudent(data: any): Observable<any> {
    return this.http.post('${this.baseUrl}/AddStudent', data);
  }

}
