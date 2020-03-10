import React from "react";
import "./App.css";
import {
  BrowserRouter as Router, Route, Switch,
} from "react-router-dom";
import LandingPage from "./landing/LandingPage";
import Test from "./general/Test";

const App = () => (
  <div className="App">
    <Router>
      <Switch>
        <Route path="/test" component={Test} />
        <Route path="" component={LandingPage} />
      </Switch>
    </Router>
  </div>
);

export default App;
