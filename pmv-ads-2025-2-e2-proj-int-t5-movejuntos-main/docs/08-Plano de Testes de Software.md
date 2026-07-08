# Plano de Testes de Software

Os requisitos para realização dos testes de software são:

- Site publicado na Internet 
- Navegador da Internet - Chrome, Firefox ou Edge.

Os testes funcionais e não funcionais a serem realizados na aplicação são descritos a seguir. 

| Caso de Teste                                | CT-RF-001.1 - Verificar auto registro                                                                                                                                                                         |
| :------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados                        | RF-001: A aplicação deve permitir que os usuários realizem auto registro e gerenciem seus dados.                                                                                                                                   |
| Objetivo do Teste                            | Validar se o usuário consegue se registrar.                                         |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Clicar em "Cadastre-se". <br> 4) Preencher os campos obrigatórios. <br> 5) Confirmar o cadastro. <br> 6) Acessar a conta |
| Critérios de êxito                           | O usuário deve ser cadastrado com sucesso 
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]         


<hr>


| Caso de Teste                                | CT-RF-001.2 - Verificar edição de informações da conta                                                                                                                                                                           |
| :------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados                        | RF-001: A aplicação deve permitir que os usuários realizem auto registro e gerenciem seus dados.                                                                                                                                   |
| Objetivo do Teste                            | Validar se o usuário consegue gerenciar seus próprios dados com sucesso.                                                                                                                                            |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Clicar em "Login". <br> 4) Preencher os campos obrigatórios. <br> 5) Confirmar o login. <br> 6) Acessar a conta e editar informações do perfil. <br> 7) Confirmar alterações. |
| Critérios de êxito                           | O usuário deve conseguir alterar seus dados pessoais.                                                                                                                                                 |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]      


<hr>

| Caso de Teste | CT-RF-001.3- Verificar exclusão de conta |
|---------------|-----------------------------------|
| **Requisitos Associados** | RF-001: A aplicação deve permitir que os usuários realizem auto registro e gerenciem seus dados.  |
| **Objetivo do Teste** | Validar se o usuário consegue excluir sua conta com sucesso. |
| **Passos** | 1) Acessar o navegador.<br>2) Informar o endereço do site. <br>3) Acessar a conta.<br>4) Entrar em configurações do perfil.<br>5) Selecionar "Excluir conta".<br>6) Confirmar exclusão. |
| **Critérios de Êxito** | A conta deve ser excluída e o usuário não deve mais conseguir acessá-la. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |


<hr>

| Caso de Teste                                | CT-RF-002 - Verificar login de usuários                                                                                                                       |
| :------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados                        | RF-002: A aplicação deve permitir que os usuários realizem login.                                                                                        |
| Objetivo do Teste                            | Validar se o usuário consegue entrar na aplicação com credenciais válidas.                                                                               |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Clicar em "Login". <br> 4) Inserir e-mail e senha. <br> 5) Confirmar o acesso. |
| Critérios de êxito                           | O sistema deve autenticar o usuário e redirecioná-lo para sua página inicial.                                                                            |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                                                   |
<hr>

| Caso de Teste                                | CT-RF-003 - Verificar recuperação de senha                                                                                                                                             |
| :------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados                        | RF-003: A aplicação deve permitir que os usuários recuperem a senha.                                                                                                              |
| Objetivo do Teste                            | Garantir que o usuário consiga recuperar sua senha esquecida.                                                                                                                     |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Clicar em "Login". <br> 4) Clicar em "Esqueceu a senha?". <br> 5) Informar o e-mail cadastrado. <br> 6) Confirmar solicitação. <br> 7) Acessar e-mail e redefinir senha. |
| Critérios de êxito                           | O usuário deve receber um link ou instruções para redefinir a senha.                                                                                                              |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                                                                            |
<hr>

| Caso de Teste                                | CT-RF-004 - Verificar exibição do mapa interativo                                                                                  |
| :------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados                        | RF-004: A aplicação deve exibir um mapa interativo com os locais cadastrados.                                                 |
| Objetivo do Teste                            | Confirmar se o mapa é exibido corretamente com os locais disponíveis.                                                         |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Clicar em "Mapa de Locais". |
| Critérios de êxito                           | O mapa deve carregar com os locais cadastrados, permitindo interação.                                                         |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                        |
<hr>

| Caso de Teste                                | CT-RF-005 - Verificar cadastro e gerenciamento de locais                                                                                                                                         |
| :------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Requisitos Associados                        | RF-005: A aplicação deve permitir cadastro e gerenciamento de locais com fotos e descrições.                                                                                                |
| Objetivo do Teste                            | Validar se o usuário consegue cadastrar, editar e excluir locais.                                                                                                                           |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Realizar login. <br> 4) Clicar em "Cadastrar Local". <br> 5) Preencher informações obrigatórias. <br> 6) Inserir fotos. <br> 7) Salvar local. <br> 8) Acessar configurações de usuário. <br> 9) Clicar em locais cadastrados. <br> 10) Editar informações já cadastradas do local ou exclusão. <br>11) Confirmar alterações ou exclusão. |
| Critérios de êxito                           | O sistema deve cadastrar e permitir gerenciamento dos locais cadastrados.                                                                                                                   |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                                                                                      |
<hr>

| Caso de Teste                                | CT-RF-006 - Verificar cadastro de avaliações de locais                                                                                                                         |
| :------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Requisitos Associados                        | RF-006: A aplicação deve permitir que os usuários avaliem os locais com notas quanto à acessibilidade a respeito de rampas, corrimãos, banheiros acessíveis, vagas de estacionamento reservadas, sinalização tátil, visual e sonora, largura de portas e corredores alem de caminhos livres de obstáculos                                                      |
| Objetivo do Teste                            | Confirmar se o usuário consegue avaliar um local atribuindo notas e especificações.                                                                                            |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Realizar login. <br> 4) Selecionar um local cadastrado. <br> 5) Acessar opção de "Avaliar". <br> 6) Selecionar nota de 1 a 5. <br> 7) Preencher especificações de acessibilidade. <br> 8) Confirmar avaliação. |
| Critérios de êxito                           | O sistema deve registrar e exibir a avaliação feita pelo usuário.                                                                                             |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                                                        |
<hr>

| Caso de Teste                                | CT-RF-007 - Verificar cadastro e exclusão de comentários                                                                                                                         |
| :------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados                        | RF-007: A aplicação deve permitir cadastro de comentários durante a avaliação do local, podendo gerenciar exclusão do próprio comentário após realizado                                                                        |
| Objetivo do Teste                            | Garantir que comentários possam ser inseridos e removidos.                                                                                                                  |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Realizar login. <br> 4) Selecionar um local cadastrado. <br> 5) Acessar opção "Avaliações". <br> 6) Inserir avaliação com comentário e salvar. <br> 7) Excluir comentário cadastrado. |
| Critérios de êxito                           | O sistema deve exibir o comentário registrado e permitir exclusão do mesmo.                                                                                                 |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                                                                      |
<hr>

| Caso de Teste                                | CT-RF-008 - Verificar busca e filtros de locais                                                                                                        |
| :------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------ |
| Requisitos Associados                        | RF-008: A aplicação deve permitir busca e filtro por categoria de local e nível de acessibilidade.                                                |
| Objetivo do Teste                            | Validar se a busca retorna resultados de acordo com os filtros selecionados.                                                                      |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Realizar login. <br> 4) Acessar tela de busca. <br> 5) Selecionar filtros por categoria e nível de acessibilidade. <br> 6) Confirmar pesquisa. |
| Critérios de êxito                           | O sistema deve exibir apenas os locais que correspondam aos filtros definidos.                                                                    |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                                            |
<hr>

| Caso de Teste                                | CT-RF-009 - Verificar upload de fotos em avaliações                                                                                                               |
| :------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados                        | RF-009: A aplicação deve permitir upload de até 5 fotos durante cada avaliação de local.                                                                     |
| Objetivo do Teste                            | Testar a funcionalidade de upload de fotos em uma avaliação.                                                                                                 |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Realizar login. <br> 4) Selecionar um local cadastrado. <br> 5) Clicar em "Avaliar". <br> 6) Inserir até 5 fotos no formulário. <br> 7) Salvar avaliação. |
| Critérios de êxito                           | O sistema deve aceitar até 5 fotos e rejeitar quantidade superior.                                                                                           |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                                                       |
<hr>

| Caso de Teste                                | CT-RF-010 - Verificar denúncias de comentários                                                                                                                                |
| :------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| Requisitos Associados                        | RF-010: A aplicação deve permitir denúncias de comentários inadequados.                                                                                                   |
| Objetivo do Teste                            | Validar a funcionalidade de denúncia de comentários.                                                                                                                      |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Realizar login. <br> 4) Selecionar um local cadastrado. <br> 5) Acessar comentários do local. <br> 6) Selecionar comentário inadequado. <br> 7) Clicar em "Denunciar". |
| Critérios de êxito                           | O sistema deve registrar a denúncia do comentário e notificar a administração.                                                                                            |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                                                                    |
<hr>

| Caso de Teste                                | CT-RF-011 - Verificar salvamento de locais favoritos                                                                                                                                |
| :------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados                        | RF-011: A aplicação deve permitir salvar locais favoritos.                                                                                                               |
| Objetivo do Teste                            | Testar a funcionalidade de favoritar e desfavoritar locais.                                                                                                              |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Realizar login. <br> 4) Selecionar um local cadastrado. <br> 5) Clicar em "Salvar como Favorito". <br> 6) Acessar lista de favoritos. <br> 7) Remover local da lista. |
| Critérios de êxito                           | O local deve aparecer na lista de favoritos e ser removido quando desfavoritado.                                                                                         |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                                                                   |
<hr>

| Caso de Teste                                | CT-RF-012 - Verificar cálculo da média das notas                                                                                                  |
| :------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------- |
| Requisitos Associados                        | RF-012: A aplicação deve permitir calcular a média simples das notas dos usuários sobre a acessibilidade, sendo notas base de 1 a 5.          |
| Objetivo do Teste                            | Validar se a média das notas atribuídas a um local é calculada corretamente.                                                                  |
| Passos                                       | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Selecionar um local cadastrado. <br> 4) Acessar avaliações registradas. <br> 6) Conferir cálculo da média exibida. |
| Critérios de êxito                           | O sistema deve apresentar corretamente a média simples das notas (1 a 5).                                                                     |
| Responsável pela elaboração do caso de Teste | \[Nome do responsável]                                                                                                                        |
<hr>

| Caso de Teste | CT-RNF-001 - Verificar responsividade da aplicação |
|---------------|----------------------------------------------------|
| **Requisitos Associados** | RNF-001: A aplicação deve ser responsiva |
| **Objetivo do Teste** | Validar se a aplicação adapta corretamente a interface em diferentes dispositivos e tamanhos de tela. |
| **Passos** | 1) Acessar a aplicação em desktop.<br> 2) Verificar adaptação automática da interface. <br> 3) Acessar a aplicação em tablet. <br> 4) Verificar adaptação automática da interface. <br>5) Acessar a aplicação em smartphone. <br> 6) Verificar adaptação automática da interface. |
| **Critérios de Êxito** | A interface deve se ajustar corretamente em todos os dispositivos sem perda de funcionalidade ou legibilidade. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |
<hr>

| Caso de Teste | CT-RNF-002 - Verificar compatibilidade com navegadores |
|---------------|---------------------------------------------------------|
| **Requisitos Associados** | RNF-002: A aplicação deve ser compatível com navegadores (Chrome, Firefox, Edge) |
| **Objetivo do Teste** | Validar se a aplicação funciona corretamente nos principais navegadores. |
| **Passos** | 1) Acessar a aplicação no Chrome. <br> 2) Acessar a aplicação no Firefox. <br> 3) Acessar a aplicação no Edge. |
| **Critérios de Êxito** | Todas as funcionalidades devem funcionar sem erros nos navegadores testados. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |
<hr>

| Caso de Teste | CT-RNF-003 - Verificar acessibilidade da interface |
|---------------|----------------------------------------------------|
| **Requisitos Associados** | RNF-003: A aplicação deve ter interface acessível (contraste, leitores de tela, design simples) |
| **Objetivo do Teste** | Garantir que a interface atenda critérios básicos de acessibilidade. |
| **Passos** | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Verificar contraste de cores. <br> 4) Navegar utilizando apenas teclado. <br> 5) Testar com leitor de tela. |
| **Critérios de Êxito** | Todos os elementos devem estar acessíveis, legíveis e navegáveis sem barreiras. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |
<hr>

| Caso de Teste | CT-RNF-004 - Verificar integração com API de mapas |
|---------------|----------------------------------------------------|
| **Requisitos Associados** | RNF-004: A aplicação deve utilizar API para mostrar mapas |
| **Objetivo do Teste** | Validar se o mapa é carregado e exibido corretamente através da API integrada. |
| **Passos** | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Verificar se o mapa é exibido. <br> 4) Testar interação com zoom e navegação. |
| **Critérios de Êxito** | O mapa deve ser exibido corretamente e responder às interações do usuário. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |
<hr>

| Caso de Teste | CT-RNF-005 - Verificar usabilidade em até 4 cliques |
|---------------|----------------------------------------------------|
| **Requisitos Associados** | RNF-005: A aplicação deve garantir que o usuário alcance seu objetivo em até 4 cliques |
| **Objetivo do Teste** | Avaliar se a navegação até as principais funcionalidades ocorre em até 4 cliques. |
| **Passos** | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Realizar fluxo de busca de local. <br> 4) Realizar cadastro de local. <br> 5) Avaliar quantidade de cliques necessários. |
| **Critérios de Êxito** | O usuário deve alcançar a funcionalidade em no máximo 4 cliques. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |
<hr>

| Caso de Teste | CT-RNF-006 - Verificar uso de C# no Back-End |
|---------------|----------------------------------------------|
| **Requisitos Associados** | RNF-006: A aplicação deve ser desenvolvida utilizando C# para o Back-End |
| **Objetivo do Teste** | Garantir que o sistema Back-End esteja implementado em C#. |
| **Passos** | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Verificar código-fonte. <br> 4) Validar execução em ambiente .NET. |
| **Critérios de Êxito** | O sistema deve rodar em C#, dentro do ambiente .NET, sem erros de compilação. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |
<hr>

| Caso de Teste | CT-RNF-007 - Verificar uso de HTML, CSS e JavaScript no Front-End |
|---------------|-------------------------------------------------------------------|
| **Requisitos Associados** | RNF-007: A aplicação deve ser desenvolvida utilizando HTML, CSS, JavaScript para Front-End |
| **Objetivo do Teste** | Garantir que o Front-End utilize as tecnologias especificadas. |
| **Passos** |1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Verificar código-fonte. <br> 4) Validar renderização no navegador. |
| **Critérios de Êxito** | A aplicação deve ser desenvolvida utilizando apenas HTML, CSS e JavaScript no Front-End. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |
<hr>

| Caso de Teste | CT-RNF-008 - Verificar uso de SQL no Banco de Dados |
|---------------|-----------------------------------------------------|
| **Requisitos Associados** | RNF-008: A aplicação deve ser desenvolvida utilizando SQL para banco de dados |
| **Objetivo do Teste** | Validar se o banco de dados foi implementado em SQL. |
| **Passos** | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Verificar scripts de criação de tabelas. <br> 4) Executar consultas SQL. |
| **Critérios de Êxito** | O banco de dados deve responder corretamente às consultas SQL. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |
<hr>

| Caso de Teste | CT-RNF-009 - Verificar tempo de carregamento dos mapas/dados |
|---------------|--------------------------------------------------------------|
| **Requisitos Associados** | RNF-009: A aplicação deve ter tempo de carregamento de mapas/dados ≤ 15s |
| **Objetivo do Teste** | Medir o tempo de carregamento dos mapas/dados. |
| **Passos** | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Acessar funcionalidade de mapa. <br> 4) Medir tempo de carregamento até exibição completa. |
| **Critérios de Êxito** | O tempo de carregamento não deve ultrapassar 15 segundos. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |
<hr>

| Caso de Teste | CT-RNF-010 - Verificar aplicação das heurísticas de Nielsen |
|---------------|-------------------------------------------------------------|
| **Requisitos Associados** | RNF-010: A aplicação deve ser construída considerando as 10 heurísticas de Nielsen |
| **Objetivo do Teste** | Avaliar a interface com base nas heurísticas de usabilidade de Nielsen. |
| **Passos** | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site. <br> 3) Avaliar consistência da interface. <br> 4) Verificar feedback do sistema. <br> 5) Testar prevenção de erros. |
| **Critérios de Êxito** | A interface deve cumprir os princípios de usabilidade definidos por Nielsen. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |
<hr>

| Caso de Teste | CT-RNF-011 - Verificar criptografia de senha |
|---------------|----------------------------------------------|
| **Requisitos Associados** | RNF-011: A aplicação deve armazenar senha criptografada para segurança de dados |
| **Objetivo do Teste** | Validar se as senhas dos usuários são armazenadas de forma criptografada. |
| **Passos** | 1) Acessar o Navegador. <br> 2) Informar o endereço do Site.<br> 3) Criar conta com senha. <br> 4) Acessar banco de dados. <br> 5) Verificar armazenamento da senha. |
| **Critérios de Êxito** | A senha deve estar armazenada de forma criptografada e não em texto simples. |
| **Responsável pela elaboração do caso de Teste** | [Nome do responsável] |

