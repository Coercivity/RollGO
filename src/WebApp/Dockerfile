FROM node:21-alpine

# Create app directory
WORKDIR /usr/src/rollgo/Webapp

# Install app dependencies
RUN npm install -g npm@9.8.0
COPY package*.json ./
RUN npm install

# Bundle app source
COPY . .
CMD ["npm", "run", "build"]