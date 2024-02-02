#!/bin/sh

# Check if SERVER_IP is set
if [ -z "$SERVER_IP" ]; then
    echo "SERVER_IP environment variable is not set."
    exit 1
fi

openssl genpkey -algorithm RSA -out rollgo.rsa && \
    openssl req -new -key rollgo.rsa -out rollgo.pem -subj "/CN=${SERVER_IP}"

openssl x509 -req -in rollgo.pem -signkey rollgo.rsa -out rollgo.crt

openssl pkcs12 -export -out rollgo.pfx -inkey rollgo.rsa -in rollgo.crt -password pass:password
