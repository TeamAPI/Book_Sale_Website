import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-contact-list-component',
  templateUrl: './contact-list-component.component.html',
  styleUrls: ['./contact-list-component.component.css']
})
export class ContactListComponentComponent implements OnInit {
  

  constructor() { }

  ngOnInit() {
  }

  Messager = "Today! I think about you";
  Printable = true;
  tabindex = 1;
  Contacts = [
    {
      name : 'Nguyễn Văn Luân',
      job: 'IT',
      avatar: {
        url: 'https://griffonagedotcom.files.wordpress.com/2016/07/profile-modern-2e.jpg'
      }
    },
    {
      name: 'Trương Đình Hiếu',
      job: 'CEOS',
      avatar: {
        url: 'https://st2.depositphotos.com/2648581/11830/i/950/depositphotos_118306518-stock-photo-young-man-profile-face-over.jpg'
      }
    },
    {
      name: 'Phan Minh Tâm',
      job: 'Bảo vệ',
      avatar: {
        url: 'https://sp.vixxmobile.com/img/profile/1803/photo_n.jpg'
      }
    }
  ]

  
  changeTab(tabindex){
    this.tabindex = tabindex;
  }
}
