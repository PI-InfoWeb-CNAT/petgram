# **Projeto Rede Social (PetGram)**

## **Especificação do caso de uso - TO COMMENT POST**

### **Histórico da Revisão**
|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/08/2021 | **1.00** | Versão Inicial  | Ueniry Felipe |

### **1. Resumo**

Este casos de uso permite que os membros da rede possam comentar postagens sobre pets

### **2. Atores**

Membros da rede

### **3. Pré-condições**

O usuário que vai fazer o comentário precisa estar autenticado no sistema (ser um membro).

### **4.Pós-condições**

O sistema deve disponibilizar de forma rápida o comentário realizado na postagem.

### **5. Fluxos de evento**

### **5.1. Fluxo Principal**

|  Ator  | Sistema |
|:-------|:------- |
|1. Usuário seleciona campo de texto de comentário||
||2. O sistema apresenta um espaço na interface para capturar o texto do comentário|
|3. O usuário preenche o texto de comentário. ||
|4. Usuário clica no botão "Enviar"||
||5. O sistema grava o comentário acrescentando a data-hora da publicação.|
|6. O usuário visualiza o comentário anexado a referida postagem.||

### **5.2. Fluxo de exceção**

 `a) Dados inválidos para a operação: caso o usuário tente submeter um comentário sem texto, o site não deve tornar o botão "Enviar" clicável`

### **6. Protótipos de Interface**

`A ser desenvolvido pelo aluno.`
