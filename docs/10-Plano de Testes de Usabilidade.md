# Plano de Testes de Usabilidade

Os testes de usabilidade permitem avaliar a qualidade da interface com o usuário da aplicação interativa.

## Definição do(s) objetivo(s)

Os testes de usabilidade têm como finalidade avaliar a experiência do usuário na aplicação, verificando:

- Se os usuários conseguem concluir tarefas essenciais (registro, login, busca e avaliação de locais) sem dificuldades.
- A performance da aplicação em cenários críticos (carregamento de mapas, uso de filtros, responsividade).
- Identificar barreiras de navegação e problemas de acessibilidade.
- Verificar clareza, satisfação e confiança do usuário na interface.
- Medir eficiência: tempo, cliques e erros até a conclusão das tarefas.

## Seleção dos participantes

Para garantir que o teste reflita o uso real do sistema, será escolhido participantes nos seguintes critérios abaixo :

### Critérios de seleção:

  -  Usuários com diferentes níveis de familiaridade com tecnologia.
  -  Pessoas com e sem experiência em aplicativos baseados em mapas.
  -  Número de erros cometidos.
  -  Mínimo: 5 participantes.
  -  Ideal: Entre 8 e 12 para maior diversidade.

### Descrição de perfil dos participantes:

  -   Idade: será coletada como dado numérico.
  -   Grau de escolaridade: será identificado por meio de uma escala categórica (Ensino Fundamental, Ensino Médio, Graduação, Pós-graduação, etc.).
  -   Afinidade com tecnologia: será medida por meio de uma escala de Likert de 5 pontos, onde:
<br> 1 – Nenhuma afinidade
<br> 2 – Baixa afinidade
<br> 3 – Afinidade moderada
<br> 4 – Alta afinidade
<br> 5 – Muito alta afinidade


## Definição de cenários de teste

**Cenário 1: Registro e Login**

**Objetivo:** Avaliar se o usuário consegue registrar-se e acessar o sistema sem dificuldades.

**Contexto:** O usuário acessou o site pela primeira vez e precisa criar sua conta para usufruir do mesmo por completo.

**Tarefa(s):** 

- Acessar a tela de login 
- Caso não tenha login , deve se cadastrar preenchendo dados obrigatórios (nome, e-mail, senha).
- Confirmar registro.
- Realizar login com os dados criados.

**Critério(s) de Sucesso(s):**

- Cadastro concluído sem erros.
- Login efetuado corretamente.
- Processo realizado em tempo hábil.

<hr>

**Cenário 2: Recuperar Senha**

**Objetivo:** Avaliar clareza e eficiência do processo de recuperação de senha.

**Contexto:** O usuário acessou o site e deseja fazer login, mas o mesmo esqueceu a senha e deseja redefini-la.

**Tarefa(s):** 

- Acessar o site e localizar tela de login.
- Acessar a opção "Esqueci minha senha"
- Informar e-mail cadastrado.
- Seguir instruções recebidas no site.
- Criar nova senha e acessar o sistema.

**Critério(s) de Sucesso(s):**

- Usuário entende o fluxo sem suporte externo.
- Site compreende a troca da senha do usuário e libera seu acesso com a nova criada.

<hr>

**Cenário 3: Busca e Filtro de Locais**

**Objetivo:** Avaliar a facilidade de localizar locais acessíveis com filtros.

**Contexto:** O usuário deseja encontrar um restaurante que seja acessível para cadeirantes. Para isso precisa entrar no site, acessar o mapa e encontrar o restaurante que tenha rampas e caminhos livres de obstáculos para acessibilidade de cadeirantes.

**Tarefa(s):** 

- Acessar o site e localizar o mapa interativo.
- Usar a barra de busca digitando “restaurante”.
- Aplicar filtros de categoria e nível de acessibilidade.
- Selecionar um local específico.

**Critério(s) de Sucesso(s):**

- Local encontrado corretamente.
- Filtros aplicados de forma intuitiva.

<hr>

**Cenário 4: Avaliar e Comentar Local**

**Objetivo:** Verificar se o usuário consegue avaliar e comentar sobre um local sem dificuldades.

**Contexto:** O usuário visitou um restaurante e deseja compartilhar sua experiência quanto a acessibilidade do local.

**Tarefa(s):** 

- Acessar o site e realizar login.
- Selecionar o local no mapa.
- Atribuir nota e especificações de acessibilidade.
- Escrever um comentário.
- Fazer upload de até 3 fotos e enviar.
  
**Critério(s) de Sucesso(s):**

- Avaliação e comentário com fotos salvos no sistema.
- Nota atribuída corretamente.

<hr>

**Cenário 5: Cadastrar Local**

**Objetivo:** Avaliar se o usuário consegue cadastrar um novo local, informando os dados básicos, acessibilidade e inclusão de fotos.

**Contexto:** Usuário deseja cadastrar uma indústria de água na sua região.

**Tarefa(s):** 
 - Acesse o site e faça login.
 - No menu principal, escolha a opção “Cadastrar novo local”.
 - Preencha os campos obrigatórios como nome, tipo e endereço.
 - Faça o upload de fotos.
 - Salve o cadastro.
 - Verifique se o local aparece corretamente no mapa do site..
  
**Critério(s) de Sucesso(s):**
- Novo local salvo corretamente.
- Novo local aparece no mapa interativo.

<hr>

**Cenário 6: Tirar uma Dúvida sobre como editar Meus Locais Cadastrados**

**Objetivo:** Usuário deve tirar uma dúvida a respeito de acessar os Meus Locais Cadastrados

**Contexto:** O usuário precisa alterar o nome do local que ele cadastrou errado.

**Tarefa(s):** 

- Acessar o site e realize login.
- Em perfil, clicar em Meus Locais.
- Renomear o local
  
**Critério(s) de Sucesso(s):**

- Usuário consegue localizar e modificar o nome do local.

<hr>

**Cenário 7: Salvar Local como Favorito**

**Objetivo:** Avaliar a clareza da função de salvar e acessar locais favoritos.

**Contexto:** O usuário encontrou um museu acessível e quer salvar para visitar depois.

**Tarefa(s):** 

- Acessar o site e realizar login.
- Selecionar o museu no mapa interativo.
- Usar a função “Salvar nos favoritos”.
- Acessar a lista de favoritos.
  
**Critério(s) de Sucesso(s):**

- Local salvo corretamente.
- Usuário acessa facilmente a lista de favoritos.

<hr>

## Métodos de coleta de dados

 ### Métricas quantitativas:

  -  Tempo gasto em cada tarefa.
  -  Número de cliques até a conclusão.
  -  Número de erros cometidos.
  -  Taxa de sucesso (quantos usuários concluíram a tarefa sem ajuda).

 ### Métricas qualitativas:

  - Observações sobre dificuldades encontradas ao longo do processo
  - Comentários verbais durante a execução.

 ### Questionário pós-teste:

 Reponda em uma escala de 1 a 5, sendo:
1 - Discordo Totalmente; 
2 - Discordo; 
3 - Nem concordo nem discordo; 
4 - Concordo; 
5 - Concordo Totalmente; a respeito das seguintes afirmações:
  - A interface do aplicativo foi fácil de aprender a usar.
  - As informações e opções na tela estavam claras e compreensíveis.
  - As tarefas puderam ser realizadas sem esforço excessivo.
  - A organização dos elementos da interface (botões, menus, ícones) facilitou o uso.

Respostas abertas:
  - Como você descreveria sua experiência geral ao usar a interface?
  - Houve algo que chamou sua atenção positivamente durante o uso?
  - Houve algo que dificultou a realização das tarefas?
  - Que mudanças ou melhorias você considera importantes para tornar o uso mais fácil?
  - Existe alguma outra sugestão ou comentário que gostaria de compartilhar?

Responda sim ou não:
 - Conseguiu cumprir a tarefa?

