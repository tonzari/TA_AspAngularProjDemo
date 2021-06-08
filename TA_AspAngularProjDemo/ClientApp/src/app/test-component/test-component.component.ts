import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { EventService } from '../event.service';

@Component({
    selector: 'app-test-component',
  templateUrl: './test-component.component.html',
  styleUrls: ['./test-component.component.css']
})

export class TestComponentComponent {

  // Create an empty array to stuff data into later.
  // What data type is the array? You have to make it.
  // Make an interface that reflects the model in your database

  public events: Event[];

  // when a test component is created, inject the event service
  constructor(private eventService: EventService) { }

  // when the test component is loaded, get all events
  ngOnInit(): void {
    this.eventService.getAllEvents().subscribe(
      (response: any) => {
        this.events = response;
      }
    )
  }
}
