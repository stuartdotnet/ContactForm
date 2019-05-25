import React, { Component } from 'react';
import { Alert } from './../Alert/Alert.js';

export class ContactForm extends Component {

  constructor(props) {
    super(props);
    this.state = {
        name: '',
        message: '',
        email: '',
        buttonText: 'Send Message',
        alertText: '',
        alertVisible: false,
        submitEnabled: true
    }
  }

  lockForm = () => {
    this.setState({
      buttonText: '...Sending...',
      alertVisible: false,
      submitEnabled: false
    })
  }

  formSubmit = (e) => {
    e.preventDefault()
    
    // TODO: client side validation :)
  
    this.lockForm();
  
    let data = {
        fromname: this.state.name,
        fromemail: this.state.email,
        text: this.state.message
    }
    
    fetch('/api/Messages', {
      method: 'POST',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json',
      },
      body: JSON.stringify(data)
    })
    .then((e) => {
      if (!e.ok) {
        this.formError(e)
      }
      else {
        this.resetForm();
        this.setState({
          alertText: 'Message sent successfully',
          alertType: 'success',
          alertVisible: true
        })
      }
    })
    .catch((e) => {
      this.formError(e);
    })
  }

  formError = (e) => {
    this.resetForm();
    this.setState({
      alertText: 'Message Not Sent',
      alertType: 'danger',
      alertVisible: true
    })
    
    console.log('Message not sent');
  }

  resetForm = () => {
    this.setState({
      name: '',
      message: '',
      email: '',
      submitEnabled: true,
      buttonText: 'Send Message'
    })
  }

  render () {
      return (
        <div>
          <h1>Contact Us</h1>
          <Alert alertVisible={this.state.alertVisible} alertText={this.state.alertText} alertType={this.state.alertType} />
          <p>Please enter your details and message below.</p>
          <form className="contact-form" onSubmit={ (e) => this.formSubmit(e)}>
            <div className="form-group">
              <label htmlFor="name">Name</label>
              <input autoFocus className="form-control" type="text" id="name" name="name" placeholder="Your name" value={this.state.name} onChange={e => this.setState({ name: e.target.value }) } required />
            </div>

            <div className="form-group">
              <label htmlFor="email">Email</label>
              <input className="form-control" type="email" id="email" name="email" placeholder="Your email address" onChange={e => this.setState({ email: e.target.value})} required />
            </div>

            <div className="form-group">
              <label htmlFor="message">Message</label>
              <textarea className="form-control" id="message" name="message" placeholder="What would you like to say?" value={this.state.message} onChange={e => this.setState({ message: e.target.value})}>
              </textarea>
            </div>

            <div className="btn-container">
              <button disabled={!this.state.submitEnabled} className="form-control" type="submit" className="btn btn-primary">{ this.state.buttonText }
              </button>
            </div>
          </form>
        </div>
      );
    }
}