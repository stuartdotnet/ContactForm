import React, { Component } from 'react';
import { ContactForm } from './ContactForm/ContactForm.js';
import { Clock } from './Clock/Clock.js';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <ContactForm />
        <Clock />
      </div>
    );
  }
}
