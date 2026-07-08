# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

## Personas

| Persona 1 | Maria, 65 anos, aposentada |
|-----------|-----------------------------|
| <img src="/docs/img/persona-aposentada.jpg" width="200" height="200"/> | <br> **Dores**: Dificuldade para saber se locais que deseja visitar são realmente acessíveis / Medo de se deparar com escadas, banheiros inacessíveis ou espaços apertados, passando por situações constrangedoras. .<br><br>**Expectativas**: Poder planejar saídas com mais autonomia e confiança / Sentir segurança ao ir a um lugar novo, sem medo de barreiras físicas ou imprevistos. |

| Persona 2 | João, 30 anos, cadeirante |
|-----------|---------------------------|
| <img src="/docs/img/joao-cadeirante.jpg" width="200" height="200"/> | **Dores**: Perde tempo procurando informações sobre acessibilidade que muitas vezes estão desatualizadas ou são imprecisas / Sente frustração e exclusão ao perceber que muitos lugares ainda não consideram as necessidades de pessoas com mobilidade reduzida..<br><br>**Expectativas**: Ter acesso a informações claras e atualizadas que o ajudem a tomar decisões com mais autonomia / Sentir-se incluído e respeitado nos espaços que frequenta, sem precisar se preocupar com barreiras inesperadas. |

| Persona 3 | Ana, 28 anos, mãe de bebê |
|-----------|---------------------------|
| <img src="/docs/img/ana-mae.jpg" width="200" height="200"/> | **Dores**: Enfrenta obstáculos em calçadas, entradas e estabelecimentos que dificultam a circulação com o carrinho / Se sente frustrada por não conseguir prever se os locais que pretende visitar têm estrutura adequada para receber pais com bebês.<br><br>**Expectativas**: Poder acessar informações claras sobre quais lugares são acessíveis para carrinhos de bebê / Sentir mais segurança ao sair com o filho, confiando em experiências de outros pais e sabendo que há rotas ou espaços adaptados. |

| Persona 4 | Lucas, 22 anos, estudante voluntário |
|-----------|--------------------------------------|
| <img src="/docs/img/lucas-estudante.jpg" width="200" height="200"/> | **Dores**: Percebe a ausência de um espaço centralizado onde informações e ações sobre acessibilidade possam ser reunidas e organizadas / Tem dificuldade em engajar e manter o interesse das pessoas, principalmente em ações colaborativas que dependem da participação da comunidade.<br><br>**Expectativas**: Participar de uma iniciativa que valorize a colaboração e estimule o engajamento de forma atrativa e acessível / Ter clareza sobre o impacto das ações realizadas, o que motiva ainda mais sua participação e a de outros. |

## Histórias de Usuários

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`|
|--------------------|------------------------------------|---------------------------------|
|Usuário com mobilidade reduzida| Consultar locais acessíveis próximos | planejar antes de sair de casa|
|Usuário| Avaliar o nível de acessibilidade de um local |que possa ajudar outras pessoas a escolherem onde vão|
|Usuário| Filtrar por tipo de local (restaurante, transporte, lazer) | encontrar rapidamente o que precisa|
|Usuário| Inserir fotos do local | validar informações de acessibilidade|
|Usuário colaborador| Avaliar comentários de outros usuários | garantir a confiabilidade das informações|

## Requisitos

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-------------------------|------------|
|RF-001| A aplicação deve permitir que os usuários realizem auto registro e gerenciem seus dados | ALTA | 
|RF-002| A aplicação deve permitir que os usuários realizem login | MÉDIA |
|RF-003| A aplicação deve permitir que os usuários recuperem a senha | BAIXA |
|RF-004| A aplicação deve exibir um mapa interativo com os locais cadastrados | ALTA |
|RF-005| A aplicação deve permitir cadastro e gerenciamento de locais com fotos e descrições | ALTA |
|RF-006| A aplicação deve permitir que os usuários avaliem os locais com notas quanto à acessibilidade a respeito de rampas, corrimãos, banheiros acessíveis, vagas de estacionamento reservadas, sinalização tátil, visual e sonora, largura de portas e corredores alem de caminhos livres de obstáculos | MÉDIA |
|RF-007| A aplicação deve permitir cadastro de comentários durante a avaliação do local, podendo gerenciar exclusão do próprio comentário após realizado | MÉDIA |
|RF-008| A aplicação deve permitir busca e filtro por categoria de local e nível de acessibilidade | ALTA |
|RF-009| A aplicação deve permitir upload de até 5 fotos durante cada avaliação de local | MÉDIA |
|RF-010| A aplicação deve permitir denúncias de comentários inadequados | BAIXA |
|RF-011| A aplicação deve permitir salvar locais favoritos | BAIXA |
|RF-012| A aplicação deve mostrar a média simples das notas dos usuários sobre a acessibilidade do estabelecimento, sendo notas base de 1 a 5 | BAIXA |
|RF-013| A aplicação deve exibir um relatório da busca de locais realizada pelo usuário | ALTA |


### Requisitos Não Funcionais

|ID     | Descrição do Requisito  | Prioridade |
|-------|-------------------------|------------|
|RNF-001| A aplicação deve ser responsiva | ALTA |
|RNF-002| A aplicação deve ser compatível com navegadores (Chrome, Firefox, Edge) | ALTA |
|RNF-003| A aplicação deve ter interface acessível (contraste, leitores de tela, design simples) | MÉDIA |
|RNF-004| A aplicação deve utilizar API para mostrar mapas | ALTA |
|RNF-005| A aplicação deve garantir que o usuário alcance seu objetivo em até 4 cliques | MÉDIA |
|RNF-006| A aplicação deve ser desenvolvida utilizando C# para o Back-End | ALTA |
|RNF-007| A aplicação deve ser desenvolvida utilizando HTLM, CSS, Java Script para Front-End | ALTA |
|RNF-008| A aplicação deve ser desenvolvida utilizando SQL para banco de dados | ALTA |
|RNF-009| A aplicação deve ter tempo de carregamento de mapas/dados ≤ 15s | BAIXA |
|RNF-010| A aplicação deve ser construída considerando as 10 heurísticas de Nielsen | MÉDIA |
|RNF-011| A aplicação deve armazenar senha criptografada para segurança de dados | ALTA |

## Restrições

|ID| Restrição |
|--|-----------|
|01| Prazo de desenvolvimento limitado ao semestre letivo |
|02| Recursos financeiros reduzidos (uso de APIs gratuitas) |

## Diagrama de Casos de Uso

<img alt="casos de uso" src="https://github.com/user-attachments/assets/7e10b872-daa0-4570-a1e6-921f8732664c" />
