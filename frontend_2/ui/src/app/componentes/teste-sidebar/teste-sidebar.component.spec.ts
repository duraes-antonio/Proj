import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TesteSidebarComponent } from './teste-sidebar.component';

describe('TesteSidebarComponent', () => {
  let component: TesteSidebarComponent;
  let fixture: ComponentFixture<TesteSidebarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TesteSidebarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TesteSidebarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
