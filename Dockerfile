FROM mcr.microsoft.com/dotnet/core/sdk:2.2
COPY . ./app
WORKDIR /app
ENV ConnStringWithSemiColons=ThisIsStuff;OtherStuff;LastlyStuff;KthxBye
RUN env | grep ConnStringWithSemiColons
RUN dotnet run