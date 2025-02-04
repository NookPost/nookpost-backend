# Learn about building .NET container images:
# https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG TARGETARCH
WORKDIR /source

# Copy project file and restore as distinct layers
COPY ./*.csproj .
RUN dotnet restore -a $TARGETARCH

# Copy source code and publish app
COPY . .
RUN ls /source
RUN dotnet publish -a $TARGETARCH --no-restore -o /app
RUN ls /app

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:8.0
ENV ASPNETCORE_HTTP_PORTS=5000
ENV ASPNETCORE_ENVIRONMENT="Development"
EXPOSE 5000
WORKDIR /app
COPY --from=build /app .
#USER $APP_UID
ENTRYPOINT ["./nookpost-backend"]