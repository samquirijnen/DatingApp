import { HttpClient, HttpParams } from "@angular/common/http";
import { map } from "rxjs";
import { environment } from "src/environments/environment";
import { PaginatedResult } from "../_models/pagination";

 let baseUrl= environment.apiUrl
 export function getPaginatedResult<T>(url,params, http: HttpClient) {
  const  paginatedResult : PaginatedResult<T> = new PaginatedResult<T>()

  if (url===(baseUrl + 'likes') ||url===(baseUrl + 'messages')) {
    return http.get<T>(url , { observe: 'response', params }).pipe(
      map(response => {
        paginatedResult.result = response.body;
        if (response.headers.get('Pagination') !== null) {
          paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
        }
        return paginatedResult;
      })
    );
  }else{
    return http.get<T>(url + 'users', { observe: 'response', params }).pipe(
      map(response => {
        paginatedResult.result = response.body;
        if (response.headers.get('Pagination') !== null) {
          paginatedResult.pagination = JSON.parse(response.headers.get('Pagination'));
        }
        return paginatedResult;
      })
    );
  }

  }

export function getPaginationHeaders(pageNumber: number, pageSize:number){
  let params = new HttpParams()

        params = params.append('pageNumber',pageNumber.toString())
        params = params.append('pageSize',pageSize.toString())

        return params

}
