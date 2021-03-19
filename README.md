# Introdução do Aplicativo
O InventoryControl é um aplicativo WindowsForm desenvolvido em C# para a 2a Etapa do Processo Seletivo da Academia do Programador 2021. Ele permite o registro, visualização, edição e exclusão de equipamentos e seus respectivos chamados de manutenção. Este aplicativo possuí persistencia de dados através de serialização / deserialização de arquivos JSON.

# Organização do Projeto
O desenvolvimento do projeto foi planejados baseado no sistema de Issues disponibilizados pelo Github, que neste projeto foram utilizados como User Stories / tarefas. Certas conveções foram seguidas a risca, como por exemplo:
  - **Prefixo no título**: *"NomeDaTarefa"*, seguido pelo caracter *"¬"* que representa a categoria geral do Issue.
  - **Sufixo no título**: sendo este o resto do título da Issue, com uma explicação breve e clara do problema.
  - **Critério de Aceitação**: critérios claros, objetivos e sem ambiguidade para a conclusão da Issue.



Todos os Issues estão organizados em forma de Kanban no Project *"Kanban - Academia Do Programador 2021"* aqui deste repositório do Github. No Kaban deste projeto, existe 4 colunas:
  - **To do**: representa as Issues que serão feitas posteriormente, ou seja, como um *"product backlog"*. Todos os novos Issues são enviados para esta coluna automaticamente.
  - **In progress**: representa as Issues que estão sendo trabalhas atualmente na sua respectiva Branch. Todos os Issues reabertos são enviados para esta coluna automaticamente.
  - **Review**: representa as as Issues stories que estão prontas na sua respectiva Branch e esperando Pull Requestt. 
  - **Done**: representa as as Issues stories que estão fechadas e já na Branch *"main"*. Todos Issues fechados são enviados para esta coluna automaticamente.



Por convenção, a maioria dos commits foram realizados em novas Branchs ao invés da Branch *"main"*. O padrão das Branchs deste repositório se baseia em *"task/"* seguido pelo *"NomeDaTarefa"*, que representa a categoria das modificações que serão realizadas nesta Branchs.


Após o desenvolvimento de todas as tarefas relevantes para uma Branch e todas as condições dos Issues estarem satisfeitas, um Pull Request que conecta com todos os Issues da categoria é aberto. Após o Merge, todos os Issues conectados ao Pull Request são fechados automaticamente. Certas conveções foram seguidas a risca, como por exemplo:
  - **Prefixo no título**: *"NomeDaTarefa"*, seguido pelo caracter *"¬"* que representa a categoria geral do Pull Request, sendo o mesmo nome das Issues e da Branch relevante.
  - **Sufixo no título**: sendo este o resto do título do Pull Request, com uma explicação breve e clara das modificações.
  - **Changelog**: explicação claros, objetivos e sem ambiguidade das modificações realizadas.
