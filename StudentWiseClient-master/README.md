# StudentWise Client

This repository contains the client for StudentWise developed with C# and Windows Forms.

## Introduction

StudentWise is a solution aimed towards students living in shared accommodation. It allows them to track events in the building, manage joint expenses, arrange agreements, and so much more.

## Features

 - A secure login system, so that no one can steal your password or impersonate you.
 - Group separation: you get only information, relevant to you.
 - Dashboard: always be in the center of events with a flexible event planning system. We have different event types, multiple states, and voting.
 - Share your expenses fairly with our expense management system.
 - Arrange agreements and file complaints if necessary.

## Architecture

Internally, we have a cloud server running our backend on Ruby on Rails which provides RESTful API. It handles the authentication requests and issues web-tokens for each user session, maintains the database, and provides all the logic for the client application. This part is covered with automated tests and automatic deployment of source code changes.

On the client-side, we have a layered C# application. The backend layer hides implementation details about the interaction with the API from the frontend layer which renders the user interface. This separation of the logic provides great opportunities for diving our work and managing compatibility through API changes.

![AP-Architecture.min](https://git.fhict.nl/I433762/studentwise-client/uploads/3f1dc8d8d3da809e74ddc826d2c87ca4/AP-Architecture.min.png)