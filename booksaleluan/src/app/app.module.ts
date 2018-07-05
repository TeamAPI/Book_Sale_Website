import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';

const routesConfig: Routes = [
  // { path: '', redirectTo: '/login', pathMatch: 'full' },
  { path: 'themsachmoi', component: ProductsComponent },
  { path: 'donhangmoi', component: NewOrderComponent },
  { path: 'login', component: LoginComponent }
  // { path: '**', component: PageNotFoundComponent }

];

import { AppComponent } from './app.component';
import { ContactListComponentComponent } from './contact-list-component/contact-list-component.component';
import { ProductsComponent } from './products/products.component';
import { LoginComponent } from './login/login.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { NewOrderComponent } from './new-order/new-order.component';

@NgModule({
  declarations: [
    AppComponent,
    ContactListComponentComponent,
    ProductsComponent,
    LoginComponent,
    PageNotFoundComponent,
    NewOrderComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routesConfig),
    FormsModule,
    HttpModule

  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
