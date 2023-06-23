AS POO 2023/1

ADD LIVRO
POST - localhost:5000/api/livros
{
  "titulo": "O Senhor dos Anéis",
  "genero": "Fantasia"
}

ADD AUTOR EM LIVRO
POST - localhost:5000/api/livros/{IDLIVRO}/autores/{IDAUTOR}

LISTAR TODOS OS LIVROS
GET - localhost:5000/api/livros

LISTAR O LIVRO POR ID
GETBYID - localhost:5000/api/livros/{IDLIVRO}

ATUALIZAR LIVRO
UPDATE - localhost:5000/api/livros/{IDLIVRO}
{
  "titulo": "O Senhor dos Anéis",
  "genero": "Fantasia"
}

DELETAR LIVRO   
DELETE - localhost:5000/api/livros/{IDLIVRO}

-------------------------------------------------------------------------------------------------

ADD AUTOR
POST - localhost:5000/api/autores
{
  "nome": "claudio"
}

LISTAR TODOS OS AUTORES
GET - localhost:5000/api/autores

LISTAR O AUTOR POR ID
GETBYID - localhost:5000/api/autores/{IDAUTOR}

ATUALIZAR AUTOR
UPDATE - localhost:5000/api/autores/{IDAUTOR}
{
  "nome": "Isa"
}


DELETAR AUTOR   
DELETE - localhost:5000/api/autores/{IDAUTOR}

-------------------------------------------------------------------------------------------------

ADD USUARIO
POST - localhost:5000/api/usuarios
{
  "nome": "JOAO"
}

EMPRESTAR LIVRO USUARIO
POST - localhost:5000/api/usuarios/{IDUSUARIO}/emprestimos/{IDLIVRO}
{
  "nome": "JOAO"
}

DEVOLVER LIVRO USUARIO
POST - localhost:5000/api/usuarios/{IDUSUARIO}/devolucoes/{IDLIVRO}
{
  "nome": "JOAO"
}

LISTAR TODOS OS USUARIOS
GET - localhost:5000/api/usuarios

LISTAR O USUARIO POR ID
GETBYID - localhost:5000/api/usuarios/{IDUSUARIO}

ATUALIZAR USUARIO
UPDATE - localhost:5000/api/usuarios/{IDUSUARIO}
{
  "nome": "rafael"
}

DELETAR USUARIO   
DELETE - localhost:5000/api/usuarios/{IDUSUARIO}