import { HttpClient } from '@angular/common/http';
import { Component, OnDestroy } from '@angular/core';
import { SignalRServiceService } from './signal-rservice.service';
import { Subscription } from 'rxjs';
import { Message } from './message';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnDestroy {
  private signalRSubscription: Subscription;

  public content: Message | undefined;

  constructor(private signalrService: SignalRServiceService) {
    this.signalRSubscription = this.signalrService.getMessage().subscribe(
      (message) => {
        this.content = message;
      });
  }

  ngOnDestroy(): void {
    this.signalrService.disconnect();
    this.signalRSubscription.unsubscribe();
  }
}
