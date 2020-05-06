import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {BranchComponent} from "./dashboard/administration-components/branch/branch.component";
import {EmployeeComponent} from "./dashboard/administration-components/employee/employee.component";
import {PostComponent} from "./dashboard/administration-components/post/post.component";
import {TemplateComponent} from "./dashboard/administration-components/template/template.component";


const routes: Routes = [
  {path: 'branch-management', component: BranchComponent},
  {path: 'employee-management', component: EmployeeComponent},
  {path: 'post-management', component: PostComponent},
  {path: 'template-management', component: TemplateComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
