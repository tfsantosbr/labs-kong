# TASK

- [x] Criar 2 microserviços de exemplo

  - [x] Criar microserviço de Orders

    - [x] Criar endpoint de Healfhcheck
    - [x] Criar endpoint de CRUD de Orders
    - [x] Adicione compatibilidade com Dockerfile

  - [x] Criar microserviço de Products

    - [x] Criar endpoint de Healfhcheck
    - [x] Criar endpoint public de categoria de Produtos
    - [x] Criar endpoint de CRUD de Produtos

- [ ] Kong

  - [ ] Estrutura

    - [ ] Provisionar o Kong no Docker Compose

  - [ ] Funcionalidades

    - [ ] Mapear endpoints de Orders
    - [ ] Adicionar Rate Limit em Orders
    - [ ] Adicionar Trotling em Orders
    - [ ] Adicionar Autenticação em Orders
    - [ ] Adicionar Autorização em Orders
    - [ ] Adicionar Monitoramento
    - [ ] Adicionar uma funcionalidade de BFF entre Orders e Products
