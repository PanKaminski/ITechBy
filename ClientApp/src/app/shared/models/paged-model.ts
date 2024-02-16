export interface PagedModel<T> {
    pageSize: number;
    currentPage: number;
    totalPages: number;
    totalCount: number;
    items: T[];
}

export interface RandomPagedModel<T> extends PagedModel<T> {
    attendedPages: number[];
}