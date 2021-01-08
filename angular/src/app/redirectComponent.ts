import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'redirect',
  template: 'redirecting...'
})
export class RedirectComponent implements OnInit {
  constructor() { }

  ngOnInit() {
    window.location.href = 'https://localhost:44320/hangfire';
  }
}
