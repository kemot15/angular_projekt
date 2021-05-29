import { HttpClient } from "@angular/common/http";
import { Inject, Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { Post } from "../models/post";
import {environment} from "src/environments/environment";
@Injectable({
  providedIn: "root",
})
export class PostService {
  private url = environment.api.path + '/posts';
  // private url = this.baseUrl + 'api/posts' //@Inject('BASE_URL') private baseUrl: string

  constructor(private httpClient: HttpClient, @Inject('BASE_URL') private baseUrl: string) {}

  savePost(post: Post): Observable<Post> {
    return this.httpClient.post<Post>(this.url, post);
  }

  getPost(): Observable<Post[]> {
    return this.httpClient.get<Post[]>(this.url);
  }
}
