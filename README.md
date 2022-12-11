# FibCalc
FibCalc is .NET 7 MVC Application built with Docker support and GitHub Actions in mind.

[Sprawozdanie](Sprawozdanie.md)

## Features
* Calculates Fibonacci number for values <= 50
* Small OCI (~50 MB) images using `runtime-deps` .NET image and `self-contained` publish method
* Dockerfile with cross-compilation for multiple platforms
* GitHub Actions workflow for continuous delivery of images for `x64` and `arm/v8` platforms.
