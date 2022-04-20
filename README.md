## Alunos: João Artur Ramos Belli, Matheus Henrique Hermes Tambosi, Vitor Adriel Roecker


### Como utilizar o Git?

  ###  Como inicializar os repositorios?
  
  `git init`
  Navegue até a pasta de repositorio desejado e execute o comando acima no terminal de comando
  
  ### Como fazer o primeiro commit no projeto?  
  Navegue até a pasta de repositorio iniciado escreva `git add .` e em seguida execute o comando `git commit`
  
  ### Como realizar commits de mudanças?
  Navegue até a pasta de repositorio iniciado e execute o comando `git commit -a` para adicionar todos os arquivos alterados. Caso queira adicionar uma mensagem ao commit execute `git commit -am 'mensagemDoSeuCommit'`
  
  ### Como compartilhar as suas mudanças com outras pessoas da equipe?
  `git push`
  O comando acima envia os commits do repositorio local para o remoto. O ideal é que você execute os comandos `git fetch`, `git pull` para manter atualizado o seu repositorio local e evitar comflitos.
  
  ### Como desfazer as alterações?
  Para poder desfazer todas as alterações locais utilizando o commando `git clean`. Ja para reverter um commit publico utilize o comando `git revert`. E quando você precisar resetar seu repositorio para um commit especifico utilize o comando `git resest nomeDoCommit`
  
  ### Como resolver conflitos de merge?
  Ao tentar enviar suas alterações para o repositorio remoto, pode acontecer de ocorrer conflitos de merge. Esses conflitos ocorrem quando duas pessoas alteram o mesmo trecho do código. Ao executar o comando `git push` os arquivos ficaram destacados onde os conflitos ocorreram.
  Exemplo: 
    `<html>
	    <head>
    <<<<<<< HEAD
		    <title>Hello World</title>
    =======
		    <title>Olá Mundo</title>
    >>>>>>> master
	    </head>
	    <body>
		    Lorem ipsum dolor sit amet consectetur ...
	    </body>
    </html>`
    
    Após resolver os conflitos você irá realizar um commit com as alterações.
    
    
   ### Como utilizar as branchs?
   Branch é uma ramificação no git. É um ponteiro para as alterações feitas nos arquivos do projeto.
   O uso das branchs servem para poder organizar melhor o desenvolvimento entre a equipe e para versionamento de código.
   1º cria uma branch a partir de uma outra branch que deseja trabalhar em cima.
   2º atualize o seu repositoruio com o comando `git fetch` para poder ter acesso a branch criada.
   3º utilize o comando `git branch` para pode listar todas as branchs.
   4º utilize o comando `git checkout nomeDaBranch` para utilizar a branch.
   5º realize suas alterações e utilize o comando `git merge nomeDaBranchOrigem` para mesclar suas alterações.
   
   ### Como encontrar bugs?
   `git diff` Diferença entre dois commits.
   `git log` Mostra todos os commits na sua branch.
   `git blame` Mostra o ultimo usuario a alterar o trecho especifo do código.
   `git bisect` Descobre qual o commit no histórico do seu projeto introduziu um "bug" (problema).
    
