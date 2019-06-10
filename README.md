## Teste Desenvovedor empresa GOL linhas aereas

## siga o passo a passo para executar o Projeto

## Passo 1º Colocar a string de conexao na classe GOL_Context GetConnectionString (na camada Infra => Projeto DataAccess)

## Passo 2º  Executar o migrations (no console nuget) na camada de Infra no Projeto Infra => Data Access apos executar => update-datase

## Passo 3º Caso for executar o projeto pelo VS => (parte de Servicos) mudar a URL dos serviços (localhost), ou se for executado pelo vsCode.. ja esta apontando para o localhost correto.