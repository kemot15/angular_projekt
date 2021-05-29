import { HttpClient } from "@angular/common/http";
import { Component, Inject, OnInit } from "@angular/core";
import { PostService } from "../core/post.service";
import { Post } from "../models/post";
// import { Table } from 'primeng/table';
// import { PrimeNGConfig } from 'primeng/api';

@Component({
  selector: "app-post",
  templateUrl: "./post.component.html",
  styleUrls: ["./post.component.css"],
})
export class PostComponent implements OnInit {
  posts: Post[];
  display: boolean = false;
  title: string = "";
  text: string = "";
  post: Post;

  constructor(
    private postService: PostService,
    private http: HttpClient,
    @Inject("BASE_URL") private baseUrl: string
  ) {
    this.getPost();
  }

  ngOnInit() {}

  getPost(): void {
    this.postService.getPost().subscribe(
      (result: Post[]) => (this.posts = <Post[]>result),
      (err: any) => console.log(err)
    );
  }

  showDialog(): void {
    this.display = true;
  }

  save(): void {
    let newPost: Post = {
      id: 0,
      title: this.title,
      text: this.text,
    };
    this.postService.savePost(newPost).subscribe(
      (result: Post) => console.log(result),
      (err: any) => console.log(err),
      () => {
        this.getPost();
        this.display = false;
        this.title = "";
        this.text = "";
      }
    );
  }
}
