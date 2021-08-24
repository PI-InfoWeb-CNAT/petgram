# Projeto Rede Social (PetGram)

## Especificação do caso de uso - MAKE DATE

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/08/2021 | **1.00** | Versão Inicial  | Ueniry Felipe |

### 1. Resumo 

Este casos de uso permite que os membros da rede possam **marcar encontros** de seus PETs.

### 2. Atores 

Membros da rede

### 3. Pré-condições

O usuário que vai fazer a postagem precisa estar autenticado no sistema.

### 4.Pós-condições

O sistema deve disponibilizar de forma rápida o novo encontro na aba de encontros.

### 5. Fluxos de evento
#### 5.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário clica na aba de dates, e seleciona 'marcar encontro'||
||2. O sistema apresenta uma interface para capturar os dados da postagem.|
|3. O usuário preenche o titulo e a descrição do encontro, imagens do seu PET, categoria do PET e localização||
||4. O sistema grava esses dados acrescentando a data-hora da publicação.|
|5. O usuário visualiza seu encontro na aba 'dates' ||


#### 5.2. Fluxo de exceção 
     a) Dados inválidos para a operação: caso o usuário tente submeter um date sem um dos dados, o sistema alerta que há dados faltantes. 

### 6. Prototipos de Interface

`A ser desenvolvido pelo aluno.`
