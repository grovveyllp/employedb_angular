import { Component } from '@angular/core';
import { IEmployee } from '../../models/emplooyee.model';
import { EmployeeService } from '../../services/employee.service';
import { CommonModule, NgFor } from '@angular/common';

@Component({
  selector: 'app-employee',
  standalone: true,
  imports: [NgFor, CommonModule],
  providers: [EmployeeService],
  templateUrl: './employee.component.html',
  styleUrl: './employee.component.css',
})
export class EmployeeComponent {
  employees?: IEmployee[];

  constructor(private readonly employeeService: EmployeeService) {
    this.employeeService.getEmployees().subscribe((employees: IEmployee[]) => {
      this.employees = employees;
    });
  }
}
