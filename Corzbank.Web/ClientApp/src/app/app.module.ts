import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import {MatDialogModule} from '@angular/material/dialog';
import { CodeInputModule } from 'angular-code-input';

import { AppComponent } from './app.component';
import { HomepageComponent } from './homepage/homepage.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { CardTranformPipe } from './pipes/card-transform.pipe';
import { PhoneTranformPipe } from './pipes/phone-transform.pipe';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { RegistrationComponent } from './header/authorization/registration/registration.component';
import { AppRoutingModule } from './app-routing.module';
import { LoginComponent } from './header/authorization/login/login.component';
import { ConfirmEmailComponent } from './header/authorization/registration/confirm-email/confirm-email.component';
import { ResentVerificationComponent } from './header/authorization/resent-verification/resent-verification.component';
import { ForgotPasswordComponent } from './header/authorization/forgot-password/forgot-password.component';
import { SetNewPasswordComponent } from './header/authorization/forgot-password/set-new-password/set-new-password.component';
import { ConfirmResettingComponent } from './header/authorization/forgot-password/confirm-resetting/confirm-resetting.component';

@NgModule({
  declarations: [
    AppComponent,
    HomepageComponent,
    HeaderComponent,
    FooterComponent,
    CardTranformPipe,
    PhoneTranformPipe,
    RegistrationComponent,
    LoginComponent,
    ConfirmEmailComponent,
    ResentVerificationComponent,
    ForgotPasswordComponent,
    SetNewPasswordComponent,
    ConfirmResettingComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatDialogModule,
    CodeInputModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
