# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copia os arquivos do projeto para o container
COPY . ./

# Restaura as dependências e compila o projeto
RUN dotnet restore
RUN dotnet publish -c Release -o /app/out

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app

# Copia os arquivos compilados da etapa anterior
COPY --from=build /app/out .

# Expor a porta que a aplicação escuta
EXPOSE 80

# Define o comando de execução da aplicação
ENTRYPOINT ["dotnet", "SeuProjeto.dll"]
