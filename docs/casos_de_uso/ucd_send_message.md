# Projeto Rede Social (PetGram)

## Especificação do caso de uso - SEND MESSAGE

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 20/08/2021 | *1.00* | Versão Inicial  | Ueniry Felipe |

### 1. Resumo 

Este casos de uso permite que os membros ou moderadores da rede possam enviar mensagens para outros usuários.

### 2. Atores 

Membros ou moderadores da rede

### 3. Pré-condições

O usuário que vai enviar a mensagem precisa estar autenticado no sistema.

### 4. Pós-condições

O sistema deve enviar a mensagem de forma rápida.

### 5. Fluxos de evento
#### 5.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário acessa o chat e seleciona o perfil da pessoa; ou o usuário passa o mouse em cima do nome da pessoa no Feed.||
||2. Após o usuário clicar, o sistema mostra uma aba de chat onde é possível a troca de mensagem entre ambas as partes.|
|3. O usuário preenche o campo de texto e clica no botão Enviar mensagem||
||4. O sistema envia mensagem e atualiza rapidamente para ambos usuários|


#### 5.2. Fluxo de exceção 
     a) Campo de mensagem sem texto: Usuário não digita nada no campo de mensagem, portanto, o botão de enviar mensagem ficará indisponível.

### 6. Prototipos de Interface

`A ser desenvolvido pelo aluno.`
