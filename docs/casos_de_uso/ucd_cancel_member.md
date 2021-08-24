# Projeto Rede Social (PetGram)

## Especificação do caso de uso - CANCEL MEMBER

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 20/08/2021 | *1.00* | Versão Inicial  | Ueniry Felipe |

### 1. Resumo 

Estes casos de uso permite que os moderadores da rede possam cancelar membros.

### 2. Atores 

Moderadores da rede

### 3. Pré-condições

O moderador que vai cancelar a conta de um membro precisa estar autenticado no sistema.

### 4. Pós-condições

O sistema deve remover todos os dados daquele usuário e enviar uma mensagem por email informando o motivo do cancelamento.

### 5. Fluxos de evento
#### 5.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O moderador acessa o perfil do usuário.||
||2. O sistema mostra o perfil do usuário |
|3. O moderador clica numa engrenagem onde é possível selecionar "Cancelar esta conta" ||
||4. O sistema apresenta um local onde é possível colocar o motivo do cancelamento |
|5. Usuário preenche os dados e confirma no botão "Cancelar esta conta" ||
||6. O sistema envia um email para o usuário informando a exclusão. |
||7. O sistema remove todos os posts, comentários, curtidas e encontros daquele perfil |

#### 5.2. Fluxo de exceção 
     a) Dados inválidos para a operação: caso o moderador tente realizar a exclusão sem inserir os dados, o sistema deve alertá-lo e solicitar os dados novamente, sem tornar clicável o botão "Cancelar esta conta".

### 6. Prototipos de Interface

`A ser desenvolvido pelo aluno.`
