FROM microsoft/dotnet:1.1.2-runtime-nanoserver

COPY ./target /app
WORKDIR /app

EXPOSE 80/tcp

ENV ASPNETCORE_URLS http://+:80

ENTRYPOINT dotnet /app/windockertest.dll

