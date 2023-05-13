drop database SGVDB;

CREATE DATABASE SGVDB;

Drop user 'istec'@'%';

Create user 'istec'@'%' identified by '123';
grant all on *.* to 'istec'@'%' with grant option;
flush privileges;



use SGVDB;

Create Table Clientes (
id int auto_increment primary key not null,
Nome varchar(30),
DataNasc date,
Email varchar(40),
Telm varchar(9),
NIF varchar(9),
Morada varchar(50)
);

Create Table Fornecedores (
id int auto_increment primary key not null,
Nome varchar(30),
NIF varchar(9),
Morada varchar(50)
);

Create Table Vendas (
id int auto_increment primary key not null,
idVenda int,
idProduto int,
quantidade smallint
);

Create Table VendasDetalhes (
id int auto_increment primary key not null,
idVenda int ,
idProduto int,
quantidade smallint
);

Create Table Encomendas(
id int auto_increment primary key not null,
idFornecedor int, 
DataEncomenda date,
DataChegada date,
PrecoTotal decimal
);

Create Table EncomendasDetalhes(
id int auto_increment primary key not null,
idEncomenda int,
idProduto int,
Quantidade smallint
);

Create Table Produtos(
id int auto_increment primary key not null,
Designacao varchar(25),
Descricao varchar(50),
Stock smallint,
Preco decimal,
idFornecedor int
);

Create Table Funcionarios(
id int auto_increment primary key not null,
Nome varchar(30),
NIF varchar(9),
Telem varchar(9),
Morada varchar(40),
Adm boolean DEFAULT 'false' );