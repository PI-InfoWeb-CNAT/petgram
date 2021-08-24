# Projeto Rede Social (PetGram)

## Especificação do caso de uso - POST

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/08/2021 | **1.00** | Versão Inicial  | Ueniry Felipe |

### 1. Resumo 

Este casos de uso permite que os membros da rede possam realizar suas postagens.

### 2. Atores 

Membros da rede

### 3. Pré-condições

O usuário que vai fazer a postagem precisa estar autenticado no sistema.

### 4.Pós-condições

O sistema deve disponibilizar de forma rápida as postagens para visualziação.

### 5. Fluxos de evento
#### 5.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário aciona a funcionalidade de realizar postagem sobre a interface gráfica do sistema.||
||2. O sistema apresenta uma interface para capturar os dados da postagem.|
|3. O usuário preenche a descrição do post, imagens, categoria da postagem, localização e dados do GPS.||
||4. O sistema grava esses dados acrescentando a data-hora da publicação.|
|5. O usuário visualiza sua postagem na lista de postagens. ||


#### 5.2. Fluxo de excessão 
     a) Dados inválidos para a operação: caso o usuário tente submeter uma postagem sem imagens ou categoria, o sistema deve alertá-lo e solicitar os dados novamente

### 6. Prototipos de Interface

`A ser desenvolvido pelo aluno.`
