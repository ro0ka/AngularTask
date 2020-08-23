import { Component } from '@angular/core';
import { Repository } from "./models/repository";
import { Product } from "./models/product.model";
import { ErrorHandlerService } from './errorHandler.service';

@Component({
    selector: 'app-root',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent {
  private lastError: string[];
  constructor(private repo: Repository, errorService: ErrorHandlerService) {
    errorService.errors.subscribe(error => {
      this.lastError = error;
    });
  }
  get error(): string[] {
    return this.lastError;
  }
  clearError() {
    this.lastError = null;
  }

  get product(): Product {
    return this.repo.product;
  }

  get products(): Product[] {
    return this.repo.products;
  }

}
