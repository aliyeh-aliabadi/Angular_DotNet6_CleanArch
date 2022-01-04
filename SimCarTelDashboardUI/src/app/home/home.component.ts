import { Component, OnInit } from '@angular/core';
import { ServerLogsService } from '../server-logs.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  public serverLogs: Array<any> = [];

  constructor(private serverLogsService: ServerLogsService) {
    //serverLogsService.get().subscribe((data: any) => this.serverLogs = data);
  }

  ngOnInit(): void {
    this.GetServerLogs();
  }

  GetServerLogs() {
    this.serverLogsService.get().subscribe((result: any) => this.serverLogs = result);
    console.log(this.serverLogs);
  }
}
