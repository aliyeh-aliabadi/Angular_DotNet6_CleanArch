import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-server-logs',
  templateUrl: './server-logs.component.html',
  styleUrls: ['./server-logs.component.css']
})
export class ServerLogsComponent implements OnInit {
  @Input() serverLogs: Array<any> = [];
  constructor() { }

  ngOnInit(): void {
    
  }


}
