import { Component, EventEmitter, OnInit } from '@angular/core';
import { RandomPagedModel } from '@shared/models/paged-model';
import { BehaviorSubject, Observable, scan, Subject, switchMap, tap } from 'rxjs';
import { UserCard } from '../../models/user-card';
import { PartnersSearchService } from '../../services/partners-search.service';

@Component({
  selector: 'app-partners-search',
  templateUrl: './partners-search.component.html',
  styleUrls: ['./partners-search.component.scss']
})
export class PartnersSearchComponent implements OnInit {
  public paginator$: Observable<RandomPagedModel<UserCard>>;

  public loading$ = new BehaviorSubject(true);
  private itemsScrolled$ = new BehaviorSubject<number[]>([]);

  constructor(private readonly partnersSearchService: PartnersSearchService,) {
  }
  ngOnInit(): void {
    this.paginator$ = this.loadPartners$();
  }

  private loadPartners$(): Observable<RandomPagedModel<UserCard>> {
    return this.itemsScrolled$.pipe(
      tap(() => { 
        this.loading$.next(true); 
      }),
      switchMap((attendedPages: number[]) => this.partnersSearchService.getPossiblePartners(attendedPages)),
      scan(
        this.updatePaginator, 
        { items: [], currentPage: 0, totalPages: 0, totalCount: 0, pageSize: 0, attendedPages: [] } as RandomPagedModel<UserCard>
      ),
      tap(() => this.loading$.next(false)),
    );
  }

  private updatePaginator(accumulator: RandomPagedModel<UserCard>, value: RandomPagedModel<UserCard>)
    : RandomPagedModel<UserCard> {
    if (value.currentPage === 1) {
      return value;
    }

    accumulator.items.push(...value.items);
    accumulator.currentPage = value.currentPage;
    accumulator.attendedPages = value.attendedPages;
    accumulator.pageSize = value.pageSize;
    accumulator.totalCount = value.totalCount;
    accumulator.totalPages = value.totalPages;

    return accumulator;
  }

  public loadMorePartners(paginator: RandomPagedModel<UserCard>): void {
    if (paginator.totalPages === paginator.attendedPages.length) {
      return;
    }

    this.itemsScrolled$.next(paginator.attendedPages);
  }
}
