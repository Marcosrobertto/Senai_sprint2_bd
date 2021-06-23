--- Sprint DML

USE ProjetoMedicals;
GO

--- Inserção de Valores nas Tabelas

INSERT INTO TipoUsuario (NomeTipoUsuario)
VALUES					('Administrador'),
						('Medico'),
						('Paciente');
GO

--- Criando registros na tabela Usuario

INSERT INTO Usuario (IdTipoUsuario, NomeUsuario, Email, Senha)
VALUES				(1, 'Marcos66', 'marcos.adm@gmail.com', 'Marcos123'),
					(2, 'Sara43', 'Sarinha44@gmail.com', 'Sara123'),
					(2, 'Derek444', 'Derek_mm@gmail.com', 'Derek123'),
					(3, 'Leticia33', 'Lele02@gmail.com', 'Leticia123'),
					(3, 'Brenda222', 'Brenda32@gmail.com', 'Brebda222'),
					(3, 'David243', 'Devid6@gmail.com', 'David'),
					(3, 'Pedro88', 'pedrada2@gmail.com', 'Pedro123'),
					(2, 'Kaio76', 'Kaio99@gmail.com', 'Kaio123'),
					(2, 'Ester432', 'ester@gmail.com', 'Ester123'),
					(2, 'Raquel23', 'raquel23@gmail.com', 'Raquel123');
GO

--- Criando registros na tabela Especialidade

INSERT INTO Especialidade	(Especialidade)
VALUES						('Acupuntera'),
							('Anestesiologia'),
							('Angiologia'),
							('Cardiologia'),
							('Cirurgia Cardiovascular'),
							('Cirurgia Da Mão'),
							('Cirurgia Do Aparelho Digestivo'),
							('Cirurgia Geral'),
							('Cirurgia Pediátrica'),
							('Cirurgia Plástica '),
							('Cirurgia Torácica'),
							('Cirurgia Vascular'),
							('Demartologia'),
							('RadioTerapia'),
							('Urologia'),
							('Pediatra'),
							('Psiquiatra ');	
GO

--- Cliando registro na tabela Clinica

INSERT INTO Clinica (NomeFantasia, Endereco, RazaoSocial, CNPJ)
VALUES				('Clinica Marcos', 'Av. Luis Gomes Bandeiras 234, São Paulo - SP', 'Medical Group', '44555678744613');
GO

--- Criando registros na tabela Medico

INSERT INTO Medico	(IdUsuario, IdEspecialidade, IdClinica, CRM)
VALUES				(2, 4, 1, '45332 - SP'),
					(3, 8, 1, '63985 - SP'),
					(5, 16, 1, '97652- SP'),
					(8, 17, 1, '88456 - SP');
GO

--- Criando registros na tabela Paciente

INSERT INTO Paciente	(IdUsuario, Nome, RG, CPF, Endereco, DataNascimento, Telefone)
VALUES					(4, 'Leticia Silva', '509548889', '57565633224', 'Rua Baltzar Barroso, 20 - Guaianazes, São Paulo - SP - 99654-346', '20/02/2000', '11 20655312'),
						(6, 'Derek', '678798435', '54642131689', 'Av. Paulista, 654 - Bela Vista , São Paulo - SP - 95679-921', '06/05/1997', '11 85639612'),
						(7, 'Pedro Souza', '129482301', '89890328443', 'Rua Luis Gomes, 344 - Jardim Moreno, São Paulo - SP - 12354-023', '12/12/1998', '11 95644535'),
						(9, 'Ester Silva', '894020760', '86940345265', 'Av. Bandeira Gomes, 543 - Jardim Das Bandeiras, São Paulo - SP - 89545-981', '24/11/2001', '11 43894534');
GO

--- Criando registro na tabela Situacao

INSERT INTO Situacao	(Situacao)
VALUES					('Realizada'),
						('Agendada'),
						('Cancelada');
GO

--- Criando registros na tabela Consulta

INSERT INTO Consulta (IdPaciente, IdMedico, IdSituacao, DataConsulta, Descricao)
VALUES				 (1, 1, 1, '13/11/2019', 'Doença arterial periférica'),
					 (2, 1, 1, '20/12/2019', 'Cardiopatia congênita'),
					 (2, 3, 1, '28/12/2019', 'Caxumba'),
					 (4, 3, 3, '03/04/2020', 'Infecções no ouvido e na garganta'),
					 (2, 3, 3, '07/05/2020', 'Catapora'),
					 (3, 4, 2, '16/05/2021', 'Transtorno bipolar'),
					 (1, 4, 2, '19/11/2021', 'Transtornos de Ansiedade');
GO
