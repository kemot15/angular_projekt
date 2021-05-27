import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
// import { Table } from 'primeng/table';
// import { PrimeNGConfig } from 'primeng/api';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {

  public posts: Post[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Post[]>(baseUrl + 'api/posts').subscribe(result => {
      this.posts = result;
    }, error => console.error(error));
  }

  ngOnInit() {
  }

}

interface Post {
  id: number;
  title: string;
  text: string;
}
