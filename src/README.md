https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-3.1&tabs=visual-studio
https://docs.microsoft.com/en-us/dotnet/architecture/grpc-for-wcf-developers/create-projectcd

1. execute dotnet --info to know the current net core version

2. if net core is not installed or the version is below net core 3.1, download it and install.
https://dotnet.microsoft.com/download/dotnet-core/3.1

in case of issues using the msi insaller, use the script installation.

3. to execute this project:

3.1 run the GrpcGreeter project (this is the server project),
it will open the browser using the URL: https://localhost:5001
this will be the server waiting for requests.

3.2 run the GrpcGreeterClient project (this is the client project)
this is a console app, which will request the procedure to the server.

4. Documentation
https://docs.microsoft.com/en-us/aspnet/core/grpc/basics?view=aspnetcore-3.1
https://docs.microsoft.com/en-us/aspnet/core/grpc/aspnetcore?view=aspnetcore-3.1&tabs=visual-studio
https://grpc.io/docs/languages/csharp/quickstart/
https://grpc.io/blog/grpc-dotnet-build/
https://docs.microsoft.com/en-us/dotnet/architecture/grpc-for-wcf-developers/create-project
https://docs.microsoft.com/en-us/aspnet/core/tutorials/grpc/grpc-start?view=aspnetcore-3.1&tabs=visual-studio-code
 https://weblog.west-wind.com/posts/2018/Jun/05/Which-NET-Core-Runtime-Download-do-you-need#download-page
