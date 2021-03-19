# Introdução
O InventoryControl é um aplicativo WindowsForm desenvolvido em C# para a 2a Etapa do Processo Seletivo da Academia do Programador 2021. Ele permite o registro, visualização, edição e exclusão de equipamentos e seus respectivos chamados de manutenção. Este aplicativo possuí persistencia de dados através de serialização / deserialização de arquivos JSON.


# Screenshots - Controle de Equipamentos
  - Equipamentos Cadastrados:

    ![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/equipamentos%20cadastrados.JPG?token=AMEQONH46H72VENE75RCSFTALZABG)

  - Adicionar novo Equipamento:

    ![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/adicionar%20equipamento.JPG?token=AMEQONGLWA27BU26W5DWWJTALZADA)

  - Editar Equipamento existente:

    ![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/editar%20equipamento.JPG?token=AMEQONEBWDB57QDOS7LFVSTALZAEC)

  - Excluir Equipamento existente:
  
    ![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/excluir%20equipamento.JPG?token=AMEQONFXW5IGIOKRG7REYUTALZAG4)
    
# Screenshots - Controle de Chamados de Manutenção
  - Chamados de Manutenção Cadastrados:

    ![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/chamados%20de%20manutenção%20cadastrados%20.JPG?token=AMEQONGD6DOYJAINGWDWO6LALZALA)

  - Adicionar novo Chamado de Manutenção:

    ![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/adcionar%20chamado%20de%20manutenção.JPG?token=AMEQONBVFG7CUHHIVIZCOJTALZAMC)

  - Editar Equipamento existente:

    ![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/editar%20chamado%20de%20manutenção.JPG?token=AMEQONHN4LNGZ6BGPV7XWXTALZANG)

  - Excluir Equipamento existente:
  
    ![alt text](https://github.com/pedro-ca/AcademiaDoProgramador2021/blob/main/Imagens/excluir%20chamado%20de%20manutenção.JPG)

# Organização do Projeto
O desenvolvimento do projeto foi planejados baseado no sistema de Issues disponibilizados pelo Github, que neste projeto foram utilizados como cartões de User Stories. Certas conveções foram seguidas a risca, como por exemplo:
  - **Prefixo no título**: *"NomeDaTarefa"*, seguido pelo caracter *"¬"* que representa a categoria geral do Issue.
  - **Sufixo no título**: sendo este o resto do título da Issue, com uma explicação breve do problema.
  - **Critério de Aceitação**: critérios claros, objetivos e sem ambiguidade para a conclusão da Issue.

![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/issue%20academia%20do%20programador.JPG?token=AMEQONBXTRW42J5W5RA6EI3ALY572)

Todos os Issues estão organizados em forma de Kanban no Project *"Kanban - Academia Do Programador 2021"* aqui deste repositório do Github. No Kaban deste projeto, existe 4 colunas:
  - **To do**: representa as Issues que serão feitas posteriormente, ou seja, como um *"product backlog"*. Todos os novos Issues são enviados para esta coluna automaticamente.
  - **In progress**: representa as Issues que estão sendo trabalhas atualmente na sua respectiva Branch. Todos os Issues reabertos são enviados para esta coluna automaticamente.
  - **Review**: representa as as Issues stories que estão prontas na sua respectiva Branch e esperando review no Pull Request. 
  - **Done**: representa as as Issues stories que estão fechadas e já na Branch *"main"*. Todos Issues fechados são enviados para esta coluna automaticamente.

![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/kaban%20academia%20do%20programador.JPG?token=AMEQONCQ6VALE655VL3GQRLALY6BW)

Por convenção, a maioria dos commits foram realizados em novas Branchs ao invés da Branch *"main"*. O padrão das Branchs deste repositório se baseia em *"task/"* seguido pelo *"NomeDaTarefa"*, que representa a categoria das modificações que serão realizadas nesta Branchs.

![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/branch%20tree%20academia%20do%20programador.JPG?token=AMEQONCR2WWSHIWMT7H4Q3TALY6CQ)

Após o desenvolvimento de todas as tarefas relevantes para uma Branch e todas as condições dos Issues estarem satisfeitas, um Pull Request que conecta com todos os Issues da categoria é aberto. Após o Merge, todos os Issues conectados ao Pull Request são fechados automaticamente. Certas conveções foram seguidas a risca, como por exemplo:
  - **Prefixo no título**: *"NomeDaTarefa"*, seguido pelo caracter *"¬"* que representa a categoria geral do Pull Request, sendo o mesmo presente nas Issues e Branch relevante.
  - **Sufixo no título**: sendo este o resto do título do Pull Request, com uma explicação breve das modificações.
  - **Changelog**: explicação claros, objetivos e sem ambiguidade das modificações realizadas.

![alt text](https://raw.githubusercontent.com/pedro-ca/AcademiaDoProgramador2021/main/Imagens/pull%20request%20academia%20do%20programador.JPG?token=AMEQONDAZ7IXJ4E4NRKCDMDALY6DM)
