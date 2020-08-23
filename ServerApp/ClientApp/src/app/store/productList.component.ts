import { Component } from "@angular/core";
import { Repository } from "../models/repository";
import { Product } from "../models/product.model";
import { Router } from "@angular/router";

@Component({
    selector: "store-product-list",
    templateUrl: "productList.component.html"
})
export class ProductListComponent {

  constructor(private repo: Repository,
    private router: Router) { }
  product: Product;

    get products(): Product[] {
        if (this.repo.products != null && this.repo.products.length > 0) {
            let pageIndex = (this.repo.paginationObject.currentPage - 1)
                * this.repo.paginationObject.productsPerPage;
            return this.repo.products.slice(pageIndex,
                pageIndex + this.repo.paginationObject.productsPerPage);
        }
    }

  selectProduct(id: number) {
    this.repo.getProduct(id);
    this.product = this.repo.product;
    // this.router.navigateByUrl("/");
  }
  
}
