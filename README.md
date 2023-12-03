# RollGO
[![WebApp CI/CD](https://github.com/Coercivity/RollGO/actions/workflows/webapp-ci.yml/badge.svg?branch=main)](https://github.com/Coercivity/RollGO/actions/workflows/webapp-ci.yml)

## Project Description
Welcome to RollGO, a fun and interactive movie selection platform where users can create lobbies, invite friends, chat, and collectively roll the dice to decide which movie to watch. With RollGO, the movie night decision-making process becomes a game, adding an element of excitement and randomness to your entertainment choices.

## Features
### 1. Lobby Creation:

- Users can create lobbies and customize them with unique names.
- Lobby creators receive a shareable link to invite friends to join the movie selection session.
### 2. User Interaction:

- In the lobby, users can see a list of participants and engage in a real-time chat with each other.
- Participants can express their movie preferences and suggestions through the chat.
### 3. Movie Addition:

- All users, including the lobby creator, can add movies to the list of potential options.
- Users can suggest a variety of movies, creating a diverse pool of choices.
### 4. Spinning Wheel Roll:

- When all users are ready, the lobby admin can initiate the spinning wheel.
- The spinning wheel randomly selects a movie from the list of added options.
### 5. Dynamic Winning Chances:

- The more a person wins, the lower their chances become in subsequent attempts.
- Encourages diversity in movie selections and ensures everyone gets a chance to influence the choice.

## Technologies Used
- **Frontend**:

   - React.js
   - Material UI
   - Vite
- **Backend**:

    - .NET 8
    - SignalR (for real-time communication)
    - Entity Framework (EF) for data access
- **Documentation**:

    - Swagger for API documentation
- **Containerization**:

    - Docker
