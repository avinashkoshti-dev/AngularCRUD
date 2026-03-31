import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Student } from './stud';
import { StudentService } from './student.service';


@Component({
  selector: 'app-stud',
  imports: [FormsModule,CommonModule],
  standalone: true,
  templateUrl: './stud.component.html',
  styleUrl: './stud.component.css'
})

export class StudComponent implements OnInit {
  // 🔹 Create Employee object using class
  student: Student = new Student();

  // 🔹 Employee list
  studentList: Student[] = [];

  isSaving: boolean = false;
constructor(private StudentService: StudentService) {}

  ngOnInit(): void {
this.loadStudents();
  }
    loadStudents(): void {
    debugger
    this.StudentService.getStudentList().subscribe((data: Student[])=>{
     this.studentList = data;
    });
  }




}
