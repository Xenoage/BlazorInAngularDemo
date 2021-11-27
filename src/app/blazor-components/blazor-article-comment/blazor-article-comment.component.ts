import { Component, EventEmitter, Input, Output } from '@angular/core';
import { BlazorAdapterComponent } from '../blazor-adapter/blazor-adapter.component';

@Component({
  selector: 'blazor-article-comment',
  template: '',
})

export class BlazorArticleCommentComponent extends BlazorAdapterComponent {
  @Input() comment: object | null = null;
}
