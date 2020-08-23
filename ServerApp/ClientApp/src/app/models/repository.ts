import { Product } from "./product.model";
import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
import { Filter, Pagination } from "./configClasses.repository";
import { Observable } from "rxjs";

const productsUrl = "/api/products";


type productsMetadata = {
    data: Product[],
    categories: string[];
}

@Injectable()
export class Repository {
    product: Product;
    products: Product[];
    filter: Filter = new Filter();
    categories: string[] = [];
    paginationObject = new Pagination();    

    constructor(private http: HttpClient) {
        //this.filter.category = "soccer";
        this.filter.related = true;
       // this.getProducts();
    }


  getProduct(id: number) {
     this.http.get<Product>(`${productsUrl}/${id}`)
      .subscribe(p => this.product = p);
  }

  getProducts() {
    let url = `${productsUrl}?related=${this.filter.related}`;
    if (this.filter.category) {
      url += `&category=${this.filter.category}`;
    }
    url += "&metadata=true";

    this.http.get<productsMetadata>(url)
      .subscribe(md => {
        this.products = md.data;
        this.categories = md.categories;
      });
  }

    
}
