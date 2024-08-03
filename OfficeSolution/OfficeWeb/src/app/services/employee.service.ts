import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { IEmployee } from '../models/emplooyee.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class EmployeeService {
  private $baseUrl = 'http://localhost:5198/api/Employee';
  constructor(private http: HttpClient) {}

  getEmployees(): Observable<IEmployee[]> {
    const apiUrl = `${this.$baseUrl}`;
    return this.http.get<IEmployee[]>(apiUrl);
  }
}
