Um cliente tem necessidade de buscar livros em um catálogo. Esse cliente quer ler e buscar esse catálogo de um arquivo JSON, e esse arquivo não pode ser modificado. Então com essa informação, é preciso desenvolver:

- Criar uma API para buscar produtos no arquivo JSON disponibilizado.
- Que seja possível buscar livros por suas especificações(autor, nome do livro ou outro atributo)
- É preciso que o resultado possa ser ordenado pelo preço.(asc e desc)
- Disponibilizar um método que calcule o valor do frete em 20% o valor do livro.

Será avaliado no desafio:

- Organização de código;
- Manutenibilidade;
- Princípios de orientação à objetos;
- Padrões de projeto;
- Teste unitário

Para nos enviar o código, crie um fork desse repositório e quando finalizar, mande um pull-request para nós.

O projeto deve ser desenvolvido em C#, utilizando o .NET Core 3.1 ou superior.

Gostaríamos que fosse evitado a utilização de frameworks, e que tivesse uma explicação do que é necessário para funcionar o projeto e os testes.

### Como executar o projeto

- É necessário possuir a versão do .NET 6 instalado na máquina.

Para executar a API 
  - Via Terminal: acesse o diretório *Catalog.API/* e digite o comando ```dotnet run```
  - Via Visual Studio: abra o arquivo Catalog.sln no diretório raíz do projeto. Na pasta **WebAPI** clique com o botão direito em **Catalog.API** e clique em ```Set as Startup Project``` ou ```Definir como projeto de inicialização``` dependendo do idioma da IDE e pressione ```F5```.
  
Para executar os testes:
  - Via Terminal: acesse o diretório *Catalog.Tests/* e digite o comando ```dotnet test```
  - Via Visual Studio: abra o arquivo Catalog.sln no diretório raíz do projeto. Na pasta **WebAPI.Tests** clique com o botão direito em **Catalog.Tests** e clique em ```Run Tests``` ou ```Executar Testes``` dependendo do idioma da IDE.
