# Build app and create self-contained file
FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS publish
ARG TARGETARCH
WORKDIR /src
COPY . .
RUN if [ "$TARGETARCH" == "amd64" ]; then \
    dotnet restore "FibCalc.csproj" --runtime alpine-x64 /p:PublishReadyToRun=false; \
  elif [ "$TARGETARCH" == "arm64" ]; then \
    dotnet restore "FibCalc.csproj" --runtime alpine-arm64 /p:PublishReadyToRun=false; \
  fi
# Set all flags and settings for trimming image size
# Bash if is used because TARGETARCH specification and runtime parameters differ (amd64 -> x64)
RUN  if [ "$TARGETARCH" == "amd64" ]; then \
    dotnet publish "FibCalc.csproj" -c Release -o /app/publish \
      --no-restore \
      --runtime alpine-x64 \
      --self-contained true \
      /p:PublishTrimmed=true \
      /p:PublishSingleFile=true \
      /p:PublishReadyToRun=false; \
  elif [ "$TARGETARCH" == "arm64" ]; then \
    dotnet publish "FibCalc.csproj" -c Release -o /app/publish \
      --no-restore \
      --runtime alpine-arm64 \
      --self-contained true \
      /p:PublishTrimmed=true \
      /p:PublishSingleFile=true \
      /p:PublishReadyToRun=false; \
  fi

# Image for running self-contained applications
# Alpine based image for the smallest image size
FROM mcr.microsoft.com/dotnet/runtime-deps:7.0-alpine AS final
WORKDIR /app
EXPOSE 80
EXPOSE 443
COPY --from=publish /app/publish .
ENTRYPOINT ["./FibCalc"]
