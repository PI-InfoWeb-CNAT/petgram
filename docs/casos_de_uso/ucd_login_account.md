# Projeto Rede Social (PetGram)

## Especificação do caso de uso - LOGIN ACCOUT

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 02/12/2021 | *1.00* | Versão Inicial  | Ueniry Felipe |

### 1. Resumo 

Este casos de uso permite que os visitantes da rede possam logar na sua conta.

### 2. Atores 

Visitantes da rede

### 3. Pós-condições

O sistema deve entrar rapidamente na conta e direcionar para o feed.

### 4. Fluxos de evento
#### 4.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário visita o site e clica em "Seja um PetGramer!"||
||2. O sistema apresenta uma interface para capturar o email e a senha da conta.|
|3. O usuário preenche o email e senha||
|4. O usuário clica no botão "Entrar" ||
||5. O sistema verifica os dados da conta e redireciona para o feed.|


#### 5.2. Fluxo de exceção 
     a) Dados inválidos para a operação: caso o usuário tente criar uma conta sem todos os dados, o sistema deve alertá-lo e solicitar os dados novamente;
     b) Se o email estiver errado, o sistema alertará "Email incorreto";
     c) Se o email estiver certo e a senha errada, o sistema dirá "Senha incorreta";


### 6. Prototipos de Interface

![Tela de login](https://awesomescreenshot.s3.amazonaws.com/image/1976766/17842430-3340c0e26303c44a98d86f84d1bd9cf0.png?X-Amz-Algorithm=AWS4-HMAC-SHA256&X-Amz-Credential=AKIAJSCJQ2NM3XLFPVKA%2F20211202%2Fus-east-1%2Fs3%2Faws4_request&X-Amz-Date=20211202T203933Z&X-Amz-Expires=28800&X-Amz-SignedHeaders=host&X-Amz-Signature=65823c489fcf4a9c20e3261e8599432056ad3562f65fdbc142d7587574ec3484 "Tela de login")