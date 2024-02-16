import { Component, Input } from '@angular/core';
import { UserCard } from '../../models/user-card';

@Component({
  selector: 'app-user-card-item',
  templateUrl: './user-card-item.component.html',
  styleUrls: ['./user-card-item.component.scss']
})
export class UserCardItemComponent {
  @Input() partner: UserCard;

  get userPic(): string {
    return '/assets/images/unknown-person.jpg';
  }

  getLanguageClass(langName: string): string {
    return 'lang-icon lang-icon-' + langName + ' complex-option_icon';
  }
}
