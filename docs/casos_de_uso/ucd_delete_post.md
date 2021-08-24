# Projeto Rede Social (PetGram)

## Especificação do caso de uso - POST

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/08/2021 | *1.00* | Versão Inicial  | Ueniry Felipe |

### 1. Resumo 

Este casos de uso permite que os membros da rede possam deletar suas postagens.

### 2. Atores 

Membros da rede

### 3. Pré-condições

O usuário que vai deletar a postagem precisa estar autenticado no sistema.

### 4. Pós-condições

O sistema deve atualizar de forma rápida, mostrando as postagens ainda disponíveis removendo a excluída.

### 5. Fluxos de evento
#### 5.1. Fluxo Principal
|  Ator  | Sistema |
|:-------|:------- |
|1. O usuário visualiza uma postagem sua||
|2. O usuário clica na engrenagem e seleciona 'Excluir postagem'||
||2. O sistema pergunta se deseja excluir mesmo|
|3. O usuário confirma.||
||4. O sistema remove a postagem, atualizando automaticamente.|


### 6. Prototipos de Interface

`A ser desenvolvido pelo aluno.`
