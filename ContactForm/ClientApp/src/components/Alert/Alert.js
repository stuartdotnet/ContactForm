import React, { Component } from 'react';

export class Alert extends Component {
    render(){
        return (
            <div>
            {
                this.props.alertVisible ? 
                <div className= { this.props.alertType ? 'alert alert-' + this.props.alertType : '' } role="alert">
                    {this.props.alertText}
                </div> 
                : null 
            }
            </div>
        )
    }
}