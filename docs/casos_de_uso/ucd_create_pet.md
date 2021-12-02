# Projeto Rede Social (PetGram)

## Especificação do caso de uso - CREATE PET

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 02/12/2021 | *1.00* | Versão Inicial  | Ueniry Felipe |

### 1. Resumo 

Este casos de uso permite que os membros da rede possam adicionar seu(s) pet(s).

### 2. Atores 

Membros da rede

### 3. Pós-condições

O sistema deve acrescentar rapidamente o(s) novo(s) pet(s).

### 4. Fluxos de evento
#### 4.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário termina finaliza seu cadastro e vai para o fluxo de adicionar PET"||
|2. O usuário preenche o nome, a categoria e a descrição do PET."||
|3. O usuário clica em Adicionar Pet. "||
||4. O sistema adiciona o novo PET para aquele usuário|
|5. Se o usuário quiser outro PET, repete os passos 2 e 3.||
|6. O usuário clica em Seja um Petgrammer!||
||7. O sistema direciona o usuário para o feed.|


#### 5.2. Fluxo de exceção 
     a) Dados em branco para a operação: caso o usuário tente adicionar um PET sem todos os dados, o sistema deve alertá-lo e solicitar os dados novamente
     b) Dados inválidos para a operação: caso o usuário tente adicionar um PET sem seguir as regras dos dados, o sistema deve solicitá-lo novamente

### 6. Prototipos de Interface

![Tela de cadastro de PET](https://awesomescreenshot.s3.amazonaws.com/image/1976766/17843779-fd0fb0cc1d936905ee6648a884b5a35c.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAJSCJQ2NM3XLFPVKA%2F20211202%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20211202T211207Z&X-Amz-Expires=28800&X-Amz-SignedHeaders=host&X-Amz-Signature=8dfcfbcdc7585825cbb54a0ed716d5914b8fcb73053808a00bd518b3192e9069 "Tela de cadastro de PET")