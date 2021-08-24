# Documento de visão

## Rede Social (Petgram)

### Histórico da Revisão 

|  Data  | Versão | Descrição | Autor |
|:-------|:-------|:----------|:------|
| 19/08/2021 |  **`1.01`** | Versão Inicial  | Kael Amir e Jéssica Dantas |


### 1. Objetivo do Projeto 

O projeto __Petgram__ tem como objetivo ser uma rede social específica para donos de pets.
 

### 2. Descrição do problema 

|         __        | __   |
|:------------------|:-----|
| **_O problema_**    | está relacionado a falta de uma rede social específica para donos de pets  |
| **_afetando_**      | pessoas que gostariam de compartilhar mídias sobre seus pets, além de informações úteis sobre como cuidar deles. |
| **_cujo impacto é_**| a falta de divulgação de cuidados necessários para com determinados tipos de pets, além do compartilhamento de mídias sobre estes em um meio específico para isso.|
| **_Uma boa solução seria_** | a criação de uma rede social que permita o comparilhamento de mídias sobre pets bem como a comunicação entre os grupos de donos de pets.|


### 3. Descrição dos usuários

| Nome | Descrição | Responsabilidades |
|:---  |:--- |:--- |
| Dono de Pets  | Membros da rede social e que compartilham informações sobre seus pets | Postam fotos e vídeos de pets, comentam, comparilham etc.|
| Visitante  | Pessoal não cadastrado como membro da rede. | Realizam apenas consultas de postagens, mas não podem fazer comentários nem favoritar uma postagem. |
| Moderador | Administrador do sistema | Além de poderem realizar as atividades inerentes aos Donos de Pets, podem fazer o desligamento de membros ou cancelamento de postagens indevidas.|

### 4. Descrição do ambiente dos usuários

Por se tratar de uma rede social, as tarefas executadas sobre o sistema são feitas pelos próprios membros ou visitantes da rede. As postagens podem ser feitas em qualquer horário e para isso o sistema deve ter a capacidade de estar habilitado a receber requições 24 horas por dia, durante os 7 dias da semana.

Os locais para interação com o sistema são diversos e estes podem ter uma variação da qualdiade de sinal de internet, fato que pode limitar o acesso ao sistema. 

### 5. Principais necessidades dos usuários
Os Donos de Pets sentem falta de um ambiente apropriado para postagens de mídias sobre seus pets. Atualmente se tem usado alguns aplicativos de rede social como Facebook, Instagram, entre outros. Como este sistemas são de cunho generalista, seus participantes precisam criar grupos específicos que os identifiquem. Isso causa uma proliferação de grupos que termina prejudicando a comunicação entre a comunidade.

Neste contexto, os donos de pet gostariam que fosse construído um sistema exclusivo para os registros e divulgação de situações que ocorrem com seus pets, como: Momentos engraçados, informações úteis sobre cuidados e medicamentos, além de poderem marcar encontros com outros donos de pet, encontrar veterinários nas redondezas do usuário etc.

Para isso, o sistema precisaria permitir a realização de postagens dos pets com: fotos, textos, vídeos, raça, espécie, além de ter um mapa. O sistema deve, também, permitir a realização de comentários por parte dos membros da rede sobre determinada postagem, enviar uma mensagem para um membro específico além, claro, gerenciar o perfil de cada membro da Petgram.


### 6.	Alternativas concorrentes
Como alternativas concorrentes existem os sistemas de rede social existentes atualmente: facebook, instagram, Twitter, etc, que podem servir como locais para grupos, onde os usuários se reúnem.

### 7.	Visão geral do produto
A nova rede social, específica para donos de pet, deve ser construída para uso em navegadores (browsers) existentes no mercado. 

Sua interface com usuário deve possuir uma boa usabilidade e para isto deve se aproximar da forma de interação já difundidas nas redes sociais existentes.

É importante que o sistema possua uma interface de comunicação com algum sistema de GPS para receber os dados dos encontros marcados e das clínicas veterinárias.

O sistema deve possuir uma logo marca que o identifique e que possa ser utilizado pelos seus membros para divulgação em eventos.


### 8. Requisitos Funcionais

| Código | Nome | Descrição |
|:---  |:--- |:--- |
| RF01 | Gerenciar perfil (conta)| Este requisito tem o propósito de habilitar o membro da rede a consultar e atualizar seus dados de perfil. |
| RF02 | Criar perfil | Permite que pessoas visitantes da rede possam realizar seu cadastro e começar a participar fazendo postagens de seus pets. |
| RF03| Separar espécies| Permite que os novos cadastrados possam ser levados às diferentes categorias do app, que são as espécies dos animais. Por exemplo: um usuário é dono de um cachorro, então pra ele é mais interessante que fique na categoria cachorro, para que possa encontrar outros donos de animais da mesma espécie, para que não fique recebendo conteúdos de espécies diferentes, que pra ele não têm utilidade. |
| RF04 | Gerenciar postagens |  Membros da rede podem criar, consultar, editar e excluir suas postagens. Como forma de moderar postagens abusivas o administrador do sistema poderá excluir uma postagem. |
| RF05 | Comentar postagens | Permite que membros da rede possam fazer comentários em postagens de outro membros. |
| RF06 | Apreciar (like) postagens | Além de poderem fazer comentários sobre uma postagem os membros da rede podem apreciar uma postagem apenas dando um like. |
| RF07 | Enviar mensagens | O sistem deve permitir a comunicação entre os membros da rede, onde as mensagens devem ser enviadas e consultas no próprio sistema. |
| RF08 | Marcar encontros | O sistema deve permitir o agendamento de encontros em locais abertos e que permitam pets, para que os usuários possam se encontrar e levar os pets. |
| RF09 | Localizar clínicas veterinárias | O sistema deve localizar clínicas veterinárias nas redondezas dos usuários, além de poderem ter um feedback dos veterinários. |
| RF10 | Localizar petshops | O sistema deve localizar petshops nas redondezas dos usuários. |
| RF011 | Cancelar membro | Por questões de ordem éticas  um membro da rede pode ter seu perfil cancelado pelo administrador da rede.|


### 9. Requisitos não-funcionais

 Código | Nome | Descrição | Categoria | Classificação
|:---  |:--- |:--- |:--- |:--- |
| RNF01 | Design responsivo| O sistema deve adaptar-se a qualquer tamanho de tela de dispositivo, seja, computador, tablets ou smart phones. | Usabilidade| Obrigatório |
| RNF02 | Criptografia de dados| Dados como senha e email do integrantes da rede devem ser gravadas de forma criptografada no banco de dados. | Segurança | Obrigatório|
| RNF03 | Facilidade de uso| O sistema deve ter uma interface amigável que possibilite a seus usuários uma interação fácil sem que para isso precise fazer treinamentos e/ou ler manuais. | Usabilidade| Obrigatório |
| RNF04 | Troca de dados |O sistema de usar uma biblioteca [GPSBabel] (https://en.wikipedia.org/wiki/GPSBabel) para manipular arquivos de GPS | Interoperabilidade | Desejável |

