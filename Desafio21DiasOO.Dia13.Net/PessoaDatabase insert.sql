Create Table PessoaFisica 
	(Id INT NOT NULL PRIMARY KEY IDENTITY,
	Cpf varchar(40),
	Nome varchar(40),
	Endereco varchar(40));


	Create Table PessoaJuridica
	(Id INT NOT NULL PRIMARY KEY IDENTITY,
	Cnpj varchar(40),
	Nome varchar(40),
	Endereco varchar(40));

	insert into PessoaFisica 
	(Cpf,Nome,Endereco) Values
	('8865665565','Testando de novo','rua do teste');


	insert into PessoaJuridica
	(Cnpj,Nome,Endereco) Values
	('879879864565','Testando','rua de teste por ai');

	select * from PessoaFisica;

	select * from PessoaJuridica;