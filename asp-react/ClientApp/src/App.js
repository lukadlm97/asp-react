import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';

import './custom.css'
import AppFooter from './components/AppFooter';
import Todos from './components/Todos';

export default class App extends Component {
    static displayName = App.name;

    state = {
        todos: [
            {
                id: 1,
                title: 'Take out the trash',
                complete:false
            },
            {
                id: 2,
                title: 'Diner with wife',
                complete: true
            },
            {
                id: 3,
                title: 'Meeting with boss',
                complete: false
            }
        ]
    }

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetch-data' component={FetchData} />
        <Todos todos={this.state.todos}/>
        <AppFooter />
      </Layout>
    );
  }
}
