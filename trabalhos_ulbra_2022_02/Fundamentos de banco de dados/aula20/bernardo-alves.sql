create table editoras(
    id int primary key auto_increment,
    nome varchar(50)
);

create table autores(
    matricula int primary key,
    nome varchar(40),
    CPF varchar(11),
    endereco varchar(50),
    data_nascimento date,
    nacionalidade varchar(30)
);

create table assuntos(
    id char(1) primary key,
    descricao varchar(40)
);

create table livros(
    id int primary key auto_increment,
    titulo varchar(80),
    preco double,
    lancamento date,
    idAssunto char(1),
    idEditora int,
    constraint livros_FKIndex1
    foreign key(idEditora) references editoras(id)
        on update CASCADE
        on delete RESTRICT,
    constraint livros_FKIndex2
    foreign key(idAssunto) references assuntos(id)
        on update CASCADE
        on delete RESTRICT
);

create table autores_livros(
    matricula int,
    idLivro int,
    constraint autores_has_livros_FKIndex1
    foreign key(matricula) references autores(matricula)
        on update cascade
        on delete restrict,
    foreign key(idLivro) references livros(id)
        on update cascade
        on delete cascade
);

insert into editoras(id, nome)
    VALUES
        (1, 'Mirandela Editora'),
        (2, 'Editora Via-Norte'),
        (3, 'Editora Ilhas Tijucas'),
        (4, 'Maria José Editora');
        
insert into assuntos(id, descricao)
    VALUES
        ('B', 'BANCO DE DADOS'),
        ('P', 'PROGRAMAÇÃO'),
        ('R', 'REDES'),
        ('S', 'SISTEMAS OPERACIONAIS');

-- TODO ADICIONAR LINHAS PARA TESTE DE EXCLUSÄO DO BANCO DE DADOS DISTRIBUÍDO_
insert into livros(id, titulo, preco, lancamento, idAssunto, idEditora)
    values
        (1, 'BANCO DE DADOS PARA A WEB', 31.20, '1999-01-10', 'B', 1),
        (2, 'PROGRAMANDO EM LINGUAGEM C', 30.00, '1997-10-10', 'P', 1),
        (3, 'PROGRAMANDO EM LINGUAGEM C++', 111.50, '1998-11-01', 'P', 3),
        (4, 'BANCO DE DADOS NA BIOINFORMATICA', 48.00, null, 'B', 2),
        (5, 'REDES DE COMPUTADORES', 42.00, '1996-09-01', 'R', 2);


insert into autores(matricula, nome, CPF, endereco, data_nascimento, nacionalidade)
    VALUES
        (1, 'Rick Ryordan', '52036883389', 'Tangará da Serra, MT', '1965-05-08', 'Brasileiro'),
        (2, 'Matias Delipetro', '35318381057', 'Teresina, PI', '1970-02-03', 'Brasileiro'),
        (3, 'Thiago Elias', '53405707706', 'Uberlândia, MG', '2000-10-11', 'Brasileiro'),
        (4, 'Mark Oda', '', 'Colombus, OH', '1960-10-11', 'Americano'),
        (5, 'Mark Oda', '', 'RIO DE JANEIRO, OH', '1960-10-11', 'Americano');


insert into autores_livros(matricula, idLivro)
    VALUES
        (1, 1), (1, 4),
        (2, 2), (2, 3),
        (4, 5);

-- 3A Monte um comando para excluir da tabela livros aqueles que possuem o código maior ou igual a 2, que possuem o preço maior que R$ 50,00 e que já foram lançados.
delete from livros where id >= 2 && preco > 50 && lancamento < CURRENT_DATE;

-- 3BEscreva o comando que seleciona as colunas NOME, CPF e ENDERECO, da tabela AUTOR, para aqueles que possuem a palavra ‘joão’ no nome.
select nome, CPF, endereco
from autores
where nome like '%joão%';

-- 3C Excluir o livro cujo título é ‘BANCO DE DADOS DISTRIBUÍDO’ ou ‘BANCOS DE DADOS DISTRIBUÍDOS’. Somente essas duas opções devem ser consideradas.
delete from livros where titulo = 'BANCO DE DADOS DISTRIBUÍDO[S*]';

-- 3D Selecione o nome e o CPF de todos os autores que nasceram após 01 de janeiro de 1990.
select nome, CPF
from autores
where data_nascimento > '1990-01-01';

-- 3E Selecione a matrícula e o nome dos autores que possuem RIO DE JANEIRO no seu endereço.
select nome, matricula
from autores
where endereco like '%rio de janeiro%'

-- 3F Atualize para zero o preço de todos os livros onde a data de lançamento for nula ou onde seu preço atual for inferior a R$ 55,00.
update livros
set preco = 0
where data_lancamento = null || preco < 55.00;

-- 3G Exclua todos os livros ondo o assunto for difrente de 'S', 'P' ou 'B'
delete from livros where idAssunto != 'S' && idAssunto != 'P' && idAssunto != 'B';

-- 3H Escreva o comando para contar quantos sao os autores cadastrados na tabela autores
select COUNT(id) as quantidade
from autores;

-- 3I Escreva o comando que apresenta qual o número médio de autores de cada livro. Você deve utilizar, novamente, a tabela AUTOR_LIVRO.
select count(idAutor) as autorPorLivro
from autores_livros
group by idAutor;

-- TODO ARRUMAR GROUP BY ERRADO
-- 3J Apresente o comando SQL para gerar uma listagem dos códigos dos livros que possuem a menos dois autores.
select count(matricula) as quantidade
from autores_livros
where quantidade >= 2
group by matricula;