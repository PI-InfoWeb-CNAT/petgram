# Projeto Rede Social (PetGram)

## Especificação do caso de uso - CREATE ACCOUNT

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 20/08/2021 | *1.00* | Versão Inicial  | Ueniry Felipe |
| 02/12/2021 | *1.00* | Poucas mudanças  | Ueniry Felipe |

### 1. Resumo 

Este casos de uso permite que os visitantes da rede possam criar sua conta.

### 2. Atores 

Visitantes da rede

### 3. Pós-condições

O sistema deve acrescentar rapidamente a nova conta adicionada.

### 4. Fluxos de evento
#### 4.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário visita o site e clica em "Seja um PetGramer!"||
||2. O sistema apresenta uma interface para capturar os dados da conta.|
|3. O usuário preenche o nome, nome de usuário, email, senha, confirmação de senha, data de nascimento e descrição.||
||4. O sistema grava esses dados acrescentando a nova conta.|


#### 5.2. Fluxo de exceção 
     a) Dados em branco para a operação: caso o usuário tente criar uma conta sem todos os dados, o sistema deve alertá-lo e solicitar os dados novamente
     b) Dados inválidos para a operação: caso o usuário tente criar uma conta sem seguir as regras dos dados, o sistema deve solicitá-lo novamente

### 6. Prototipos de Interface

![Tela de cadastro do usuário](https://awesomescreenshot.s3.amazonaws.com/image/1976766/17843464-88e1818ad282dfe80d221825c93a7bfd.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAJSCJQ2NM3XLFPVKA%2F20211202%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20211202T210309Z&X-Amz-Expires=28800&X-Amz-SignedHeaders=host&X-Amz-Signature=e3bbd57ccd4ef3c0d3f3119a612fd7fd99f180c999610fb96ab895e53134e8b7 "Tela de cadastro do usuário")