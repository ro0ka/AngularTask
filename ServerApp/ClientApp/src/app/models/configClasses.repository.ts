export class Filter {
    category?: string;
    related: boolean = false;

    reset() {
        this.category =  null;
        this.related = false;
    }
}

export class Pagination {

    productsPerPage: number = 4;
    currentPage = 1;
}
