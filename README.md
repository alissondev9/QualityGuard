# QualityGuard.Tests

Projeto desenvolvido em .NET com foco na implementação de testes unitários utilizando xUnit, aplicado a um sistema de validações de listas e strings.

## Objetivo do Projeto

Este projeto foi criado como parte de um desafio da DIO – Trilha .NET, com o intuito de:
- Implementar testes unitários em um sistema existente
- Cobrir cenários positivos e negativos
- Aumentar a confiabilidade do software
- Facilitar a identificação de bugs e regressões
- Aplicar boas práticas de testes automatizados

## Projeto Console

Responsável por conter as regras de negócio e validações do sistema.

### Validações de Lista
- Remoção de números negativos
- Verificação da existência de um número na lista
- Multiplicação dos elementos da lista
- Retorno do maior número
- Retorno do menor número

### Validações de String
- Contagem de caracteres de um texto
- Verificação de trecho contido no texto
- Verificação se o texto termina com determinado trecho

## Projeto de Testes

Projeto responsável por validar o comportamento do sistema através de testes unitários com xUnit.

### Testes de Lista
- Deve remover números negativos da lista
- Deve conter um número específico na lista
- Não deve conter um número inexistente
- Deve multiplicar os elementos da lista por um fator
- Deve retornar o maior número da lista
- Deve retornar o menor número da lista

### Testes de String
- Deve retornar a quantidade correta de caracteres
- Deve encontrar uma palavra existente no texto
- Não deve encontrar uma palavra inexistente
- Deve validar se o texto termina com uma palavra específica

## Tecnologias Utilizadas
- .NET 6
- C#
- xUnit
- Microsoft.NET.Test.Sdk

## Como Executar o Projeto

Pré-requisitos:
- .NET SDK 6.0 ou superior

Passos:
1. Clonar o repositório
2. Acessar a pasta raiz do projeto
3. Executar o comando:

dotnet test

## Licença

Projeto desenvolvido para fins educacionais como parte da plataforma Digital Innovation One (DIO).
