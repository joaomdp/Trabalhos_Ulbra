create table assuntos(
    id char(1) primary key,
    descricao varchar(40) not null
);

create table editoras(
    id int auto_increment primary key,
    nome varchar(40) not null
);

create table livros(
    id int auto_increment primary key,
    id_assunto char(1) not null,
    id_editora int not null,
    titulo varchar(80) not null,
    preco double,
    lancamento date,

    constraint livros_fk_assuntos
        foreign key livros(id_assunto) references assuntos(id)
        on update cascade
        on delete restrict,
    constraint livros_fk_editoras
        foreign key livros(id_editora) references editoras(id)
        on update cascade
        on delete restrict
);

create table autores(
    matricula int primary key,
    nome varchar(40) not null,
    cpf varchar(11) unique,
    endereco varchar(50) not null,
    data_nascimento date not null,
    nacionalidade varchar(30) not null
);

create table autores_livros(
    matricula_autores int not null,
    id_livro int not null,

    constraint autores_livros_fk_autores
        foreign key autores_livros(matricula_autores) references autores(matricula)
        on update cascade
        on delete restrict,
    constraint autores_livros_fk_livros
        foreign key autores_livros(id_livro) references livros(id)
        on update cascade
        on delete cascade
);


-- Monte comandos de inclusão das tabelas do Banco de dados Criado de acordo com os dados das tabelas abaixo:
    INSERT into editoras(nome)
    VALUES	('MIRANDELA EDITORA'),
            ('EDITORA VIA-NORTE'),
            ('EDITORA ILHAS TIJUCAS'),
            ('MARIA JOSÉ EDITORA');
            
    SELECT * from editoras
    

    INSERT INTO assuntos(id, descricao)
    VALUES	('B', 'BANCO DE DADOS'),
            ('P', 'PROGRAMAÇÃO'),
            ('R', 'REDES'),
            ('S', 'SISTEMAS OPERACIONAIS');

    SELECT * from assuntos

    INSERT INTO livros(titulo, preco, lancamento, id_assunto, id_editora)
    VALUES	('BANCOS DE DADOS PARA WEB', 31.20, '1999-01-10', 'B', 1),
            ('PROGRAMANDO EM LINGUAGEM C', 30.00, '1997-10-01', 'P', 1),
            ('PROGRAMANDO EM LINGUAGEM C++', 111.50, '1998-01-11', 'P', 3),
            ('BANCOS DE DADOS NA BIOINFORMÁTICA', 48.00, 0, 'B', 2),
            ('REDES DE COMPUTADORES', 42.00, '1996-09-01', 'R', 2);

    SELECT * from livros

    INSERT into autores(matricula, nome, cpf, endereco, data_nascimento, nacionalidade)
    VALUES 	(100, 'João Manoel', '98765432101', 'Rua Tal, 000', '2002-04-15', 'Brasileiro'),
    		(101, 'Vinicius', '12345678901', 'Rua Aquela, 111', '1995-10-17', 'Italiano'),
            (102, 'Jorge', '75395185241', 'Rua Uma, 222', '1989-11-22', 'Canadense'),
            (103, 'Carlos', '74185296336', 'Rua Sei la, 333', '2005-08-16', 'Alemão');

    select * from autores

    insert into autores_livros(matricula_autores, id_livro)
    VALUES
        (100, 1), (100, 4),
        (101, 2), (101, 3),
        (102, 5), (103, 5);

    select * from autores_livros

-- Alterando o nome dos atributos conforme o exercício
    ALTER TABLE editoras 
    RENAME COLUMN id TO Código;

    ALTER TABLE livros 
    RENAME COLUMN id TO Código;

    ALTER TABLE livros 
    RENAME COLUMN id_assunto TO Assunto;

    ALTER TABLE livros 
    RENAME COLUMN id_editora TO Editora;
   
    alter table assuntos
    RENAME COLUMN id to Sigla

-- Monte um comando para excluir da tabela livros aqueles que possuem o código maior ou igual a 2, que possuem o preço maior que R$ 50,00 e que já foram lançados.
    DELETE from livros
    where código >= 2 
    and preco > 50
    and lancamento <> 0;

    SELECT * from livros

-- Escreva o comando que seleciona as colunas NOME, CPF e ENDERECO, da tabela AUTOR, para aqueles que possuem a palavra ‘joão’ no nome.
    SELECT nome, cpf, endereco
    FROM autores 
    where nome like '%João%'

-- Excluir o livro cujo título é ‘BANCO DE DADOS DISTRIBUÍDO’ ou ‘BANCOS DE DADOS DISTRIBUÍDOS’. Somente essas duas opções devem ser consideradas.
    delete from livros
    where titulo = 'BANCO DE DADOS DISTRIBUÍDO[S*]';
    
    SELECT * from livros

-- Selecione o nome e o CPF de todos os autores que nasceram após 01 de janeiro de 1990.
    SELECT nome, cpf
    FROM autores 
    where data_nascimento > '1990-01-01'
   
-- Selecione a matrícula e o nome dos autores que possuem RIO DE JANEIRO no seu endereço.
    SELECT nome, matricula
    FROM autores 
    where endereco like '%Rio de Janeiro%'

-- Atualize para zero o preço de todos os livros onde a data de lançamento for nula ou onde seu preço atual for inferior a R$ 55,00.
    update livros 
    SET	preco = 0
    WHERE lancamento= null OR preco <= 55.00;
    
    SELECT * FROM livros

-- Exclua todos os livros onde o assunto for diferente de ‘S’, ‘P’, ou ‘B’.
    delete from livros 
    where Assunto <> 'S' 
    AND Assunto <> 'P' 
    AND Assunto <> 'B';

    select * from livros

-- Escreva o comando para contar quantos são os autores cadastrados na tabela AUTORES.
    SELECT COUNT(matricula) as Quantidade	
    from autores;
   

-- Escreva o comando que apresenta qual o número médio de autores de cada livro. Você deve utilizar, novamente, a tabela AUTOR_LIVRO. 
    select count(matricula_autores) as autorPorLivro
    from autores_livros
    group by matricula_autores;

-- Apresente o comando SQL para gerar uma listagem dos códigos dos livros que possuem a menos dois autores.
    select id_livro, count(matricula_autores) as quantidade_autores, livros.titulo
    from autores_livros
        inner join livros
            on livros.Código = autores_livros.id_livro
    group by id_livro
    having quantidade_autores >= 2;
    -- Escreva o comando para apresentar o preço médio dos livros por código de editora. Considere somente aqueles que custam mais de R$ 45,00.
    SELECT AVG(preco) as preco_medio, editora
    from livros 
    WHERE preco > 45.00
    group by editora;

-- Apresente o preço máximo, o preço mínimo e o preço médio dos livros cujos assuntos são ‘S’ ou ‘P’ ou ‘B’, para cada código de editora.
    SELECT max(preco) as maior_preco, MIN(preco) as menor_preco, avg(preco) as preco_medio, editora
    FROM livros 
    WHERE Assunto='S' OR Assunto='P' OR Assunto='B'
    group by editora;
   


-- Altere o comando do exercício anterior para só considerar os livros que já foram lançados (data de lançamento inferior a data atual) e cujo o preço máximo é inferior a R$ 100,00.
    SELECT max(preco) as maior_preco, MIN(preco) as menor_preco, avg(preco) as preco_medio, editora
    FROM livros 
    WHERE (Assunto='S' OR Assunto='P' OR Assunto='B')
    and lancamento < current_date
    group by editora
    having preco_maximo < 100;


-- JOIN

-- Estão sendo estudados aumentos nos preços dos livros. Escreva o comando SQL que retorna uma listagem contendo o titulo dos livros, e mais três colunas: uma contendo os preços dos livros acrescidos de 10% (deve ser chamada de ‘Opção_1’), a segunda contendo os preços acrescidos de 15% (deve ser chamada de ‘Opção_2’) e a terceira contendo os preços dos livros acrescidos de 20% (deve ser chamada de ‘Opção_3’). Somente devem ser considerados livros que já tenham sido lançados.
    SELECT preco*1.100 as Opção_1, preco*1.150 as Opção_2, preco*1.200 as Opção_3
    FROM livros 
    where lancamento <> 0;

-- Escreva o comando SQL que apresenta uma listagem contendo o código da editora, o nome da editora, a sigla do assunto e o titulo dos livros que já foram lançados. Os dados devem estar em ordem decrescente de preço, e ascendente de código da editora e de título do livro.
    select e.Código, e.nome, l.Assunto, l.titulo, l.preco
    from livros l
        inner join editoras e
            on l.Editora = e.Código && l.lancamento < CURRENT_DATE
    order by l.preco DESC, l.Editora ASC, l.titulo ASC;

-- Escreva o comando que apresente uma listagem dos nomes dos autores e do seu ano e mês de nascimento, para os autores brasileiros e que tem livros ainda não lançados. A listagem deve estar ordenada em ordem crescente de nome.
    select a.nome, CONCAT(month(data_nascimento), '/', year(data_nascimento)) as nascimento, l.titulo, l.lancamento
    from autores_livros al
        inner join autores a
            on al.matricula_autores = a.matricula
        inner join livros l
            on al.id_livro = l.Código
    where l.lancamento > CURRENT_DATE
    order by a.nome DESC;
-- Escreva o comando que retorna o nome dos autores e o título dos livros de sua autoria. A listagem deve estar ordenada pelo nome do autor, mostrar somente os livros já lançados.
    select a.nome, l.titulo
    from autores_livros al
        right join autores a
            on a.matricula = al.matricula_autores
        inner join livros l
            on al.id_livro = l.Código
    where l.lancamento <= CURRENT_DATE
    ORDER BY a.nome;

-- Monte a consulta SQL que retorna as editoras que publicaram livros escritos pela autora 'Ana da Silva'
    select e.nome, l.titulo, a.nome
    from autores_livros al
        inner join livros l
            on l.Código = al.id_livro
        inner join autores a
            on a.matricula = al.matricula_autores
        inner join editoras e
            on e.Código = l.Editora
    having a.nome = 'Ana da Silva';

--  FUS (faça um SQL) que apresente o título do livro e o nome da editora que o publicaram para todos os livros que custam menos que 50 reais.
    select l.titulo, e.nome, l.preco
    from livros l
        inner join editoras e
            on l.Editora = e.Código
    having l.preco < 50;

-- FUS que apresente o CPF, nome do autor e o preço máximo dos livros de sua autoria. Apresente somente as informações para os autores cujo preço máximo for superior a 50.
    select a.cpf, a.nome, max(l.preco) as max_preço
    from autores_livros al
        inner join autores a
            on a.matricula = al.matricula_autores
        inner join livros l
            on l.Código = al.id_livro
    group by al.matricula_autores
    having max_preço > 50;